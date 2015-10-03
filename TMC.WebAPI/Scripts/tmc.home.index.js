/// <reference path='..\jquery-1.5.1.js' />
/// <reference path='..\tmc.common.js' />
/// <reference path='..\tmc.dataService.js' />

var homeIndex;

function HomeIndex() {


    var context = this;

    this.messages = {};
    this.dialogBoxLabels = {};
    this.actionLinks = {};


    this.initialize = function () {

        /* home image slider */
        $('.flexslider').flexslider({
            slideshowSpeed: 5000,
            animationSpeed: 3000,
            controlNav: false,
            directionNav: false,
            prevText: '',
            nextText: ''
        });
        
        /* Cities autocomplete */
        $("#ddlCities").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "..//api/city/" + $("#ddlCities").val(),
                    dataType: "json",
                    //data: { searchStr: $("#ddlCities").val() },
                    success: function (data) {
                        response($.map(data, function (item) {
                            return {
                                label: item.name,
                                id: item.cityId,
                                cityDetails: item.lat + ',' + item.long + ',' + item.radius + ','
                            };
                        }));
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                $('#hdnCityName').val(ui.item.label);
                $('#hdnCityId').val(ui.item.id);
                $('#hdnCityDetails').val(ui.item.cityDetails);
                $("#divPlaces").removeClass("display-none");
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        });

        /* Places autocomplete */
        $("#ddlPlaces").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "..//api/placeAutoComplete/" + $("#hdnCityDetails").val() + $("#ddlPlaces").val(),
                    dataType: "json",
                    success: function (data) {
                        response($.map(data.predictions, function (item) {
                            return {
                                label: item.description,
                                id: item.place_id     // EDIT
                            };
                        }));
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                $('#hdnPlaceId').val(ui.item.id);
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        });


        /* Categories autocomplete */
        $("#ddlCategories").autocomplete({
            source: function (request, response) {
                $.ajax({
                    //method: 'GET',
                    url: "..//api/category/" + $("#ddlCategories").val(),
                    dataType: "json",
                   // data: { searchStr: $("#ddlCategories").val() },
                    success: function (data) {
                        response($.map(data, function (item) {
                            return {
                                label: item.name,
                                id: item.categoryId     // EDIT
                            };
                        }));
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                $('#hdnCategoryName').val(ui.item.label);
                $('#hdnCategoryId').val(ui.item.id);
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        });

        tmcCommon.attachEvent(document, 'click', '#btnSearchMain', function () {
            var listingUrl = '..//localboard/Index/' + $('#hdnCityName').val() + '/' + $('#hdnCategoryName').val() + '/' + $('#hdnCityId').val() + '/' + $('#hdnCategoryId').val() + '/' + $('#hdnPlaceId').val();
           
            window.location.href = listingUrl;
        });
    };

}
