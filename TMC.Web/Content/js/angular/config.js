(function () {
    angular.module('tmcConfig', [])
        .constant('config', {
            webApiBaseUrl: "https://foo.com/bar",
            version: "v2",
            serviceBase: "http://localhost:44444/"
        });
})();