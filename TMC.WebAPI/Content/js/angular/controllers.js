/// <reference path='..\lib/angular.js' />


tmcControllers.controller('ListingCtrl', ['$scope', '$rootScope', 'listingService', 'tmcHttpService', 'FileUploader', '$http', function ($scope, $rootScope, listingService, tmcHttpService, FileUploader, $http) {
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

    function checkIfCategoryAdded(categoryId) {
        var addedCategories = $scope.listingCategories.filter(function(category) {
            return category.categoryId == categoryId;
        });
        return addedCategories.length > 0;
    }

    $scope.addCategory = function () {
        var selectedCategoryId = parseInt($(addEditListing.categoryIdControlId).val());
        var selectedCategoryName = $(addEditListing.categoryNameControlId).val();
        if (selectedCategoryId !== "") {
            if (checkIfCategoryAdded(selectedCategoryId)) {
                alert("Key category already added.");
                return;
            }
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

    $scope.deleteListingCategory = function(category) {
        tmcHttpService.delete('/api/listing/deleteListingCategory/' + category.listingCategoryId)//todo
         .success(function (data) {
             if (data) {
                 var index = $scope.listingCategories.indexOf(category);
                 $scope.listingCategories.splice(index, 1);
             }
         })
        .error(function (error) {
            $scope.status = 'Unable to delete category: ' + error.message;
            console.log($scope.status);
        });
    };

    /****************************************************************************
    Listing Service Locations
    *****************************************************************************/
    $scope.listingServiceLocations = {};
    getListingServiceLocations();
    function checkIfServiceLocationAdded(serviceLocatioId) {
        var addedLocations = $scope.listingServiceLocations.filter(function (location) {
            return location.cityId == serviceLocatioId;
        });
        return addedLocations.length > 0;
    }
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
        var selectedCityId =parseInt( $(addEditListing.cityIdControlId).val());
        var selectedCityName = $(addEditListing.cityNameControlId).val();
        if (selectedCityId) {
            if (checkIfServiceLocationAdded(selectedCityId)) {
                alert("Service area added already");
                return;
            }
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

    $scope.deleteListingServiceLocation = function (serviceLocation) {
        tmcHttpService.delete('/api/listing/deleteListingServiceLocation/' + serviceLocation.listingServiceLocationId)//todo
         .success(function (data) {
             if (data) {
                 var index = $scope.listingServiceLocations.indexOf(serviceLocation);
                 $scope.listingServiceLocations.splice(index, 1);
             }
         })
        .error(function (error) {
            $scope.status = 'Unable to delete service area: ' + error.message;
            console.log($scope.status);
        });
    };

    /****************************************************************************
    Listing Payment Modes
    *****************************************************************************/
    $scope.paymentModes = [{//todo to be kept in a Enum class and retrieve the same in cashed calls
        "listingPaymentModeId": 0,
        "paymentModeId": 1,
        "name": "Cash",
        "isSelected": false,
        "isAdded": false,
        "isRemoved": false,
        "isChanged": false
    }, {
        "listingPaymentModeId": 0,
        "paymentModeId": 2,
        "name": "Credit Card",
        "isSelected": false,
        "isAdded": false,
        "isRemoved": false,
        "isChanged": false
    }, {
        "listingPaymentModeId": 0,
        "paymentModeId": 3,
        "name": "Debit Card",
        "isSelected": false,
        "isAdded": false,
        "isRemoved": false,
        "isChanged": false
    }, {
        "listingPaymentModeId": 0,
        "paymentModeId": 4,
        "name": "Cheque",
        "isSelected": false,
        "isAdded": false,
        "isRemoved": false,
        "isChanged": false
    }];

    $scope.listingServiceLocations = {};
    getListingPaymentModes();

    function getListingPaymentModes() {
        tmcHttpService.get('/api/listing/20/paymentmodes')//todo
         .success(function (data) {
             //  $scope.listingServiceLocations = data.serviceLocations;
             updatePaymentModesResut(data.paymentModes);
         })
        .error(function (error) {
            $scope.status = 'Unable to load  data: ' + error.message;
            console.log($scope.status);
        });
    }

    function resetPaymentModes() {
        $scope.paymentModes.forEach(function (pmode) {
            pmode.isSelected = false;
            pmode.isAdded = false;
            pmode.isRemoved = false;
            pmode.isChanged = false;
            pmode.listingPaymentModeId = 0;
        });
    }

    function updatePaymentModesResut(paymentModesResult) {
        resetPaymentModes();
        paymentModesResult.forEach(function (paymentMode) {
            $scope.paymentModes.forEach(function (pmode) {
                if (pmode.paymentModeId === paymentMode.paymentModeId) {
                    pmode.isSelected = true;
                    pmode.listingPaymentModeId = paymentMode.listingPaymentModeId;
                }
            });
        });
    }

    $scope.paymentModeChanged = function (paymentMode, checked) {
        var idx = $scope.paymentModes.indexOf(paymentMode);
        if (!checked) {
            $scope.paymentModes[idx].isRemoved = true;

        } else {
            $scope.paymentModes[idx].isAdded = true;
        }
        $scope.paymentModes[idx].isChanged = !($scope.paymentModes[idx].isChanged);
    };

    $scope.updatePaymentModes = function () {
        // todo update in single clicks later 
        var postData = [];
        $scope.paymentModes.forEach(function (paymentMode) {
            if (paymentMode.isChanged) {
                if (paymentMode.isAdded) {
                    postData.push({ listingPaymentModeId: 0, paymentModeId: paymentMode.paymentModeId, listingId: 20 });//todo
                }
                if (paymentMode.isRemoved) {
                    postData.push({ listingPaymentModeId: paymentMode.listingPaymentModeId, paymentModeId: paymentMode.paymentModeId, listingId: 20 });//todo
                }
            }
        });
        if (postData.length > 0) {
            tmcHttpService.post('/api/listing/addUpdateListingPaymentModes', postData)
             .success(function (data) {
                 getListingPaymentModes();
                 //updatePaymentModesResut(data);
                 alert("Payment modes saved successfully.");
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
    Listing Media Upload
    ****************************************************************************/
    //Get the medias uploaded
    $scope.listingMedias = {};
    getListingMedias();

    function getListingMedias() {
        tmcHttpService.get('/api/listing/20/medias')//todo
         .success(function (data) { 
             updateMediasResult(data.medias);
         })
        .error(function (error) {
            $scope.status = 'Unable to load  data: ' + error.message;
            console.log($scope.status);
        });
    }

    $scope.pofilePicUrl = "http://localhost:59974/bytes/sample.JPG/sdfd";
    $scope.showPreview = function (url) {
        $scope.previewUrl = url;
    };
    $scope.hidePreview = function () {
        $scope.previewUrl = '';
    };

    $scope.returnViewUrl = function() {
        return $scope.previewUrl == '' ? $scope.pofilePicUrl : $scope.previewUrl;
    };
    $scope.uploadedFiles = [];

    function updateMediasResult(mediasResult) {
        mediasResult.forEach(function (mediaItem) {
            var queItem = new Tmc.QueueItem(mediaItem);
            if (mediaItem.isProfile) {
                $scope.pofilePicUrl = queItem.url;
            }
            $scope.uploadedFiles.push(queItem);
        });
        for (var i = 0; i < $scope.uploadedFiles.length; i++) {
            var fileItems = [];
            fileItems[i] = new FileUploader.FileItem(uploader, $scope.uploadedFiles[i]);
            fileItems[i].progress = 100;
            fileItems[i].isUploaded = true;
            fileItems[i].isSuccess = true; 
            uploader.queue.push(fileItems[i]);
        } 
    }

    //Uploader
    var uploader;
    $scope.uploader = new FileUploader({
        url: '../api/UploadApi'
    });
    uploader = $scope.uploader;

    // FILTERS
    uploader.filters.push({
        name: 'imageFilter',
        fn: function (item /*{File|FileLikeObject}*/, options) {
            var type = '|' + item.type.slice(item.type.lastIndexOf('/') + 1) + '|';
            return '|jpg|png|jpeg|bmp|gif|'.indexOf(type) !== -1;
        }
    });
    
    // CALLBACKS
    $scope.removeFile = function (item) {
        if (item.file.mediaId == undefined) {
            item.file.mediaId = item._file.mediaId;
        }
        
        // alert("Going to delete media with id = " + item.file.mediaId);
        tmcHttpService.delete('/api/listing/deleteListingMedia/' + item.file.mediaId)//todo
         .success(function (data) {
             if (data) {
                 item.remove();
             }
         })
        .error(function (error) {
            $scope.status = 'Unable to delte media: ' + error.message;
            console.log($scope.status);
        });
        
    };
    $scope.makeProfile = function (item) {
        if (item.file.isProfile == undefined) {
            item.file.isProfile = item._file.isProfile;
        }
        item.file.isProfile = true;
        $scope.pofilePicUrl = item._file.url; 
        // reset all others
        for (var j = 0; j < uploader.queue.length; j++) {
            if (uploader.queue[j].file.name != item.file.name) { 
                uploader.queue[j].file.isProfile = false;
            }
        }
        
    };
    uploader.onWhenAddingFileFailed = function (item /*{File|FileLikeObject}*/, filter, options) {
        console.info('onWhenAddingFileFailed', item, filter, options);
    };
    uploader.onAfterAddingFile = function (item) {
        console.info('onAfterAddingFile', item);
        for (var j = 0; j < this.queue.length - 1; j++) {
            if (this.queue[j].file.name == item.file.name) { //todo
                alert("File already uploaded.");
                item.remove();
            }
        }
        item.file.mediaId = 0;
        item.isProfile = false;
    };
    uploader.onAfterAddingAll = function (addedFileItems) {
        console.info('onAfterAddingAll', addedFileItems);
    };
    uploader.onBeforeUploadItem = function (item) {
        item.file.mediaId = 0;
        item.file.url = "";
        
        console.info('onBeforeUploadItem', item);
    };
    uploader.onProgressItem = function (fileItem, progress) {
        console.info('onProgressItem', fileItem, progress);
    };
    uploader.onProgressAll = function (progress) {
        console.info('onProgressAll', progress);
    };
    uploader.onSuccessItem = function (fileItem, response, status, headers) {
        fileItem.file.mediaId = response[0].listingMediaId;
        console.info('onSuccessItem', fileItem, response, status, headers); 
    };
    uploader.onErrorItem = function (fileItem, response, status, headers) {
        console.info('onErrorItem', fileItem, response, status, headers);
    };
    uploader.onCancelItem = function (fileItem, response, status, headers) {
        console.info('onCancelItem', fileItem, response, status, headers);
    };
    uploader.onCompleteItem = function (fileItem, response, status, headers) {
        console.info('onCompleteItem', fileItem, response, status, headers);
    };
    uploader.onCompleteAll = function () {
        console.info('onCompleteAll');
    };

    console.info('uploader', uploader);

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

 
 */