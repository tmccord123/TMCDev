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
                                id: item.cityId     // EDIT
                            };
                        }));
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                $('#hdnCityName').val(ui.item.label);
                $('#hdnCityId').val(ui.item.id);
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
            window.location.href = '..//localboard/Index/' + $('#hdnCityName').val() + '/' + $('#hdnCategoryName').val() + '/' + $('#hdnCityId').val() + '/' + $('#hdnCategoryId').val();
        });
    };

}
