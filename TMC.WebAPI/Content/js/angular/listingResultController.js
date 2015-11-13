/// <reference path='..\lib/angular.js' />


tmcControllers.controller('ListingResultCtrl', ['$scope', '$rootScope', 'listingService', 'tmcHttpService', function ($scope, $rootScope, listingService, tmcHttpService) {
    $scope.testValue1 = "This line is coming from the Listing angular controllerr ";

    /****************************************************************************
    Listing results
    *****************************************************************************/
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

    $scope.parameters = {
        "pageindex": 1,
        "pagesize": 1,
        "cityId": 1,
        "categoryId": 1,
        "placeId": 1
    };
    $scope.listingResults = [];
    $scope.getMoreListingData = function() {
        getListingData();
    };

    function getListingData() {
        var postData = {
            "pageindex": 1,
            "pagesize": 1,
            "cityId": 1,
            "categoryId": 1,
            "placeId": 1
        };
        tmcHttpService.post('/api/listing/GetListingsResult', postData)//todo
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

    /*      $.ajax({
            type: 'GET',
            url: '/LocalBoard/GetListingsResult',
            data: {
                "pageindex": 1,
                "pagesize": 1,
                "cityId": 1,
                "categoryId": 1,
                "placeId": 1
            },
            dataType: 'html',
            success: function (data) {
                if (data != null) {
                    $("#listingContainer").append(data);
                }
            }
            ,
            beforeSend: function () {
                $("#listingProgress").show();
            },
            complete: function () {
                $("#listingProgress").hide();
            },
            error: function () {
                alert("Error while retrieving data!");
            }
        });
    }*/     
 

}]);
 