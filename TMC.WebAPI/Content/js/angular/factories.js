var tmcFactories = angular.module('tmcFactories', []);



tmcFactories.service('listingService', ['$http', function ($http) {
    var listingService = {};
    listingService.getListingCategories = function () {
        return $http.get('..//api/listing/20/categories');
    };
    return listingService;

}]);

 



//olds
/*
tmcFactories.factory('tmcRepo', function ($rootScope, userService, cloudService) {
    var data = { school: {}, path: null };
    var states = [];
    var school = {}, route, cohort = {}, round = {};
    $rootScope.$on('receiveSchoolsResponse', function (event, schools) {
        angular.forEach(schools, function (s) {
            states.push(new tmc.State(s));
        });
        $rootScope.$apply();
    });
    return repo = {
        getSchools: function () {
            return states;
        },
        setRoute: function (path) {
            route = path;
            data.path = path;
            cloudService.saveSettings(data);
        },
        getRoute: function () {
            var s = cloudService.loadSettings();
            if (s.data !== undefined) {
                data.path = s.data.path;

            }          
            return data.path;
        },
        setSchool: function (s) {
            school = s;
            data.school = s;
            cloudService.saveSettings(data);
        },
        getSchool: function () {
            var setting = cloudService.loadSettings();           
            if (setting.data !== undefined) {
                data.school = setting.data.school;
                
            } else {
                data.school.schoolName = "Select School";
            }
            return data.school;
        },
        cohort: cohort,
        round: round
    };
});

 

tmcApp.factory('signalRHubProxy', ['$rootScope',
    function ($rootScope) {
        function signalRHubProxyFactory(hubName) {
            var connection = $.hubConnection();
            connection.logging = true;
            var proxy = connection.createHubProxy(hubName);
            proxy.on('error', function (e) {
                console.log("ERROR");
                toastr.error(e);
            });
            connection.start().done(function () {
                console.log('SignalR ' + hubName + ' started succesfully');
                $rootScope.$broadcast('hubReadyResponse', hubName);
            }).fail(function (e) {
                console.log('SignalR error: ' + error);
            });
            return {
                on: function (eventName, callback) {
                    proxy.on(eventName, function (result) {
                        $rootScope.$apply(function () {
                            if (callback) {
                                callback(result);
                            }
                        });
                    });
                },
                off: function (eventName, callback) {
                    proxy.off(eventName, function (result) {
                        $rootScope.$apply(function () {
                            if (callback) {
                                callback(result);
                            }
                        });
                    });
                },
                invoke: function (methodName, params, callback) {
                    proxy.invoke(methodName, params)
                        .done(function (result) {
                            $rootScope.$apply(function () {
                                if (callback) {
                                    callback(result, 'success');
                                }
                            });
                        }).fail(function () {
                            if (callback) {
                                callback(result, 'error');
                            }
                        });
                },
                connection: connection
            };
        };
        return signalRHubProxyFactory;
    }]);
 */