/// <reference path='..\lib/angular.js' />


tmcControllers.controller('ListingResultCtrl', ['$scope', '$rootScope', 'listingService', 'tmcHttpService', function ($scope, $rootScope, listingService, tmcHttpService) {
    $scope.testValue1 = "This line is coming from the Listing angular controllerr ";

    /****************************************************************************
    Listing results
    *****************************************************************************/
    var parameters = {
        "pageindex": 1,
        "pagesize": 1,
        "cityId": 1,
        "categoryId": 1,
        "placeId": "",
        "sortBy": ""
    };

    initialize();
    function initialize() {
        getListingData();
       /* $(window).scroll(function () {
            if ($(window).scrollTop() == $(document).height() - $(window).height()) {
                //context.GetData();
                getListingData();
                //$scope.getMoreListingData();
            }
        });*/
    }

    
    $scope.listingResults = [];
    $scope.getMoreListingData = function() {
        getListingData();
    };

    function getListingData() {        
        tmcHttpService.post('/api/listing/GetListingsResult', parameters)//todo
            .success(function(resultData) {
                resultData.forEach(function(resultDataItem) {
                    $scope.listingResults.push(resultDataItem);
                });
            })
            .error(function(error) {
                $scope.status = 'Unable to fetch  data: ' + error.message;
                console.log($scope.status);
            });
    };   
     
    //---------------------------------------------------------------------------------------
    var navType = {
        "simple": "1",
        "dropdown": "2"
    }
    $scope.navPanes = [
    { title: "Top Results", content: "1", type: navType.simple, active: "active" },
     { title: "Distance", content: "2", type: navType.dropdown, items: [{ title: "1 km", content: "2_1" }, { title: "2 km", content: "2_2" }, { title: "3 km", content: "2_3" }, { title: "4 km", content: "2_4" }, { title: "5 km", content: "2_5" }] },
      { title: "Ratings", content: "3", type: navType.simple },
    { title: "Best Deal", content: "4", type: navType.simple }
    ];

    $scope.active = function () {
        return $scope.navPanes.filter(function (pane) {
            return pane.active;
        })[0];
    };
    $scope.navClick = function (content,navItemType) {
        var selectedNavigation = content.split("_");
        var activePane = null;
        setNavActive(selectedNavigation[0]);
        if (!(navItemType === navType.dropdown)) {
            parameters.sortBy = content;
            getListingData();
        }
    };

    function setNavActive(navContent) {
        $scope.navPanes.forEach(function (pane) {
            if (pane.content == navContent) {                
                pane.active = "active";
            } else {
                pane.active = "";
            }
        });
    };
    //------------------------------------------------------------------------------------
}]);
 