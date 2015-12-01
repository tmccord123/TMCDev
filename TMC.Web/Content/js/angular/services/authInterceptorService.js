'use strict';
tmcApp.factory('authInterceptorService', ['$q', '$injector', '$location', 'localStorageService', function ($q, $injector, $location, localStorageService) {

    var authInterceptorServiceFactory = {};

    var _request = function(config) {

        config.headers = config.headers || {};

        // var authData = localStorageService.get('authData'); this is not working
        var authData = JSON.parse(localStorage.getItem('authData'));  
        
        if (authData) {
            config.headers.Authorization = 'Bearer ' + authData.token;
        }

        return config;
    };

    var _responseError = function (rejection) {
        var authService = $injector.get('authService');
        if (rejection.status === 401) {
           
            var authData = localStorageService.get('authData');

            if (authData) {
                if (authData.useRefreshTokens) {
                    $location.path('/refresh');
                    return $q.reject(rejection);
                }
            }
            authService.logOut();
            $location.path('http://localhost:55555/Account/Login');
        }
        authService.logOut();
        window.location.href = 'http://localhost:55555/Account/Login';
        return $q.reject(rejection);
    };

    authInterceptorServiceFactory.request = _request;
    authInterceptorServiceFactory.responseError = _responseError;

    return authInterceptorServiceFactory;
}]);