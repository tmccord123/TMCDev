/// <reference path='..\lib/angular.js' />
var tmcControllers = angular.module('tmcControllers', []);

tmcControllers.controller('ListingCtrl', ['$scope','$rootScope', 'listingService', function ($scope, $rootScope, listingService) {
    $scope.testValue = "This line is coming from the Listing angular controllerr ";

    $scope.listingCategories = {};
    //$rootScope.currentTabIndex = 0;
    //addEditListing.currentTabIndex = 0;
    
    getListingCategories();
     
    function getListingCategories() {
        listingService.getListingCategories()
            .success(function (cats) {
                $scope.listingCategories = cats.categories;
               // console.log($scope.students);
            })
            .error(function (error) {
                $scope.status = 'Unable to load  data: ' + error.message;
                console.log($scope.status);
            });
    }
}]);

/*
/*School Controller for the left-side nav#1#
tmcControllers.controller('SchoolCtrl', ['$scope','$rootScope', '$location', 'userService', 'tmcRepo', function ($scope, $rootScope, $location, userService, tmcRepo) {
    $scope.states = tmcRepo.getSchools();
    $scope.$on('raiseHubInitializationComplete', function (event) {
        userService.getSchools();
    });
    userService.initializeService();
    $scope.setSchool = function (school) {
        tmcRepo.setSchool(school);
        $rootScope.setRouteDescription(tmcRepo.getRoute());
    }
    $scope.getRoute = function () {
        return tmcRepo.getRoute();
    }
    $scope.currentSchool = function () {
        return tmcRepo.getSchool();
    };
}]);

/*Project Controller to display list of projects#1#
tmcControllers.controller('ProjectCtrl', function ($scope, $rootScope, tmcRepo) {
    $scope.setRoute = function(path) {
        tmcRepo.setRoute(path);
        $rootScope.setRouteDescription(path);
    };  
    $scope.school = function () {
        return tmcRepo.getSchool();
    };
    $scope.routeDescription = "Current Projects ";

    $scope.$watch('$viewContentLoaded', function () {
        if (window.location.href.indexOf("home") > -1) {
            $scope.routeDescription = "Current Projects ";
        } else {
            var path = tmcRepo.getRoute();
            $rootScope.setRouteDescription(path);
        }
    });

    $rootScope.setRouteDescription = function (routePath) {
        var routeDesc = $scope.routeDescription;
        switch(routePath) {
            case "rp":
                routeDesc = "Round Programming ";
                break;
           default:
                break;
        }
        $scope.routeDescription = routeDesc;   
    };

});

tmcControllers.controller('BreadCrumbCtrl', function ($scope, tmcRepo, starkRepository) {
    $scope.school = function () {
        return tmcRepo.getSchool();
    };
    $scope.cohort = function () {
        return starkRepository.cohort;  
    };
    $scope.round = function () {
        return starkRepository.round; 
    };
});
 */