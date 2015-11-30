var tmcApp = angular.module('tmcApp', ['tmcFactories', 'tmcControllers', 'angularFileUpload', 'angular-loading-bar', 'tmcConfig', 'LocalStorageModule']);
var tmcControllers = angular.module('tmcControllers', []);
var tmcFactories = angular.module('tmcFactories', []);
/*tmcApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.
        when('/rp/:schoolId', {
            templateUrl: 'Models/partials/RoundProgramming.html',
            controller: 'RPCtrl'
        }).
        otherwise({
            redirectTo: '/home'
        });
}]);*/

tmcApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});