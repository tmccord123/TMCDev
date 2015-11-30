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

    var _responseError = function(rejection) {
        if (rejection.status === 401) {
            var authService = $injector.get('authService');
            var authData = localStorageService.get('authData');

            if (authData) {
                if (authData.useRefreshTokens) {
                    $location.path('/refresh');
                    return $q.reject(rejection);
                }
            }
            authService.logOut();
            $location.path('/login');
        }
        return $q.reject(rejection);
    };

    authInterceptorServiceFactory.request = _request;
    authInterceptorServiceFactory.responseError = _responseError;

    return authInterceptorServiceFactory;
}]);