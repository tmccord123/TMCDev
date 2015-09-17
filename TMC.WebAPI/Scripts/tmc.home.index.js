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
                    url: "http://localhost:59974//api/cityapi/",
                    dataType: "json",
                    data: { searchStr: $("#ddlCities").val() },
                    success: function (data) {
                        var obj = {};
                        $.each(data, function (i, v) {
                            obj[v.cityId] = v.name;
                        });
                        response(obj);
                    }
                });
            },
            minLength: 2,
            //select: function (event, ui) {
            //    log(ui.item ?
            //      "Selected: " + ui.item.label :
            //      "Nothing selected, input was " + this.value);
            //},
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
                    url: "http://localhost:59974//api/categoryapi/",
                    dataType: "json",
                    data: { searchStr: $("#ddlCategories").val() },
                    success: function (data) {
                        var obj = {};
                        $.each(data, function (i, v) {
                            obj[v.categoryId] = v.name;
                        });
                        response(obj);
                    }
                });
            },
            minLength: 2,
            //select: function (event, ui) {
            //    log(ui.item ?
            //      "Selected: " + ui.item.label :
            //      "Nothing selected, input was " + this.value);
            //},
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        });

        tmcCommon.attachEvent(document, 'click', '#btnSearchMain', function () {
            alert('Functionality required');
        });
    };

}
