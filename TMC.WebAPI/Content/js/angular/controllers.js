/// <reference path='..\lib/angular.js' />
var tmcControllers = angular.module('tmcControllers', []);

tmcControllers.controller('ListingCtrl', ['$scope', '$rootScope', 'listingService', 'tmcHttpService', function ($scope, $rootScope, listingService, tmcHttpService) {
    $scope.testValue = "This line is coming from the Listing angular controllerr ";

    /****************************************************************************
    Listing Categories
    *****************************************************************************/
    $scope.listingCategories = {};
    getListingCategories();

    function getListingCategories() {
        tmcHttpService.get('/api/listing/20/categories')//todo
         .success(function (cats) {
             $scope.listingCategories = cats.categories;
             // console.log($scope.students);
         })
        .error(function (error) {
            $scope.status = 'Unable to load  data: ' + error.message;
            console.log($scope.status);
        });

        /*listingService.getListingCategories()
            .success(function (cats) {
                $scope.listingCategories = cats.categories;
               // console.log($scope.students);
            })
            .error(function (error) {
                $scope.status = 'Unable to load  data: ' + error.message;
                console.log($scope.status);
            });*/
    }

    $scope.addCategory = function () {

        var selectedCategoryId = $(addEditListing.categoryIdControlId).val();
        var selectedCategoryName = $(addEditListing.categoryNameControlId).val();
        if (selectedCategoryId !== "") {
            var postData = { categoryId: selectedCategoryId, name: selectedCategoryName, listingId: 20 };//todo
            tmcHttpService.post('/api/listing/addCategory', postData)
             .success(function (data) {
                 $scope.listingCategories.push(data);
                 $(addEditListing.categoryIdControlId).val('');
                 $(addEditListing.categoryNameControlId).val('');
                 $("#ddlAddCategories").val('');
             })
            .error(function (error) {
                $scope.status = 'Unable to add category: ' + error.message;
                console.log($scope.status);
            });
        } else {
            //todo swow message
        }
    };


    /****************************************************************************
    Listing Service Locations
    *****************************************************************************/
    $scope.listingServiceLocations = {};
    getListingServiceLocations();

    function getListingServiceLocations() {
        tmcHttpService.get('/api/listing/20/serviceLocations')//todo
         .success(function (data) {
             $scope.listingServiceLocations = data.serviceLocations;
         })
        .error(function (error) {
            $scope.status = 'Unable to load  data: ' + error.message;
            console.log($scope.status);
        });
    }
    $scope.addListingServiceAreaWholeCity = function () {

        var selectedCityId = $(addEditListing.cityIdControlId).val();
        var selectedCityName = $(addEditListing.cityNameControlId).val();
        if (selectedCityId !== "") {
            var postData = { cityId: selectedCityId, cityName: selectedCityName, listingId: 20 };//todo
            tmcHttpService.post('/api/listing/addServiceLocation', postData)
             .success(function (data) {

                 $scope.listingServiceLocations.push(data);
                 $(addEditListing.cityIdControlId).val('');
                 $(addEditListing.cityNameControlId).val('');
                 $("#ddlAddCities").val('');
             })
            .error(function (error) {
                $scope.status = 'Unable to add city: ' + error.message;
                console.log($scope.status);
            });
        } else {
            //todo swow message
        }



    };
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