/// <reference path="jquery-1.5.1.js" />
/// <reference path="tmc.common.js" />

function tmcDataService() {

    this.ajaxFormSuccessHandler = '';

    // ajax call
    this.getJSONData = function (query, ajaxActionUrl, success, failure, showLoader, hideLoader, asyncMode, context) {
        var url = ajaxActionUrl;

        if (showLoader === true) {
            tmcCommon.showLoader();
        }

        if (asyncMode !== undefined) {
            $.ajaxSetup({
                async: asyncMode
            });
        }

        $.getJSON(url, query, function (result) {
            handleResult(result, success, failure, hideLoader, context);
        }).error(tmcCommon.handleError);

        $.ajaxSetup({ async: true, cache: false });
    };

    // ajax call
    this.postData = function (query, ajaxActionUrl, success, failure, showLoader, hideLoader, asyncMode, context) {
        var url = ajaxActionUrl;

        if (showLoader === true) {
            tmcCommon.showLoader();
        }

        if (asyncMode !== undefined) {
            $.ajaxSetup({
                async: asyncMode
            });
        }

        $.post(url, query, function (result) {
            handleResult(result, success, failure, hideLoader, context);
        }).error(tmcCommon.handleError);

        $.ajaxSetup({ async: true, cache: false });
    };

    // error handled ajax form
    this.load = function (selector, url, data, asyncMode, showPageLoader, hidePageLoader, showDivLoader, showSlideDownEffect, callbackFunction, context) {
        $.ajaxSetup({
            async: asyncMode,
            error: tmcCommon.handleError,
            cache: false
        });

        if (showDivLoader === true && showSlideDownEffect === true && showPageLoader === false) {
            $(selector).html('');
            $(selector).append('<div id="partialviewLoader" class="partialContentLoader"></div>');

            $('#partialviewLoader').fadeOut('normal', function () {
                $(selector).load(url, data, function (result) {
                    $(selector).addClass('displayNone');
                    $(selector).hide().slideDown(1500);
                    loadSuccess(result, callbackFunction, showDivLoader, context, selector);
                });
            });
        }
        else if (showDivLoader === true && showSlideDownEffect === false && showPageLoader === false) {
            $(selector).empty();
            $(selector).append('<div id="partialviewLoader" class="partialContentLoader"></div>');

            $('#partialviewLoader').fadeOut('normal', function () {
                $(selector).load(url, data, function (result) {
                    loadSuccess(result, callbackFunction, showDivLoader, context, selector);
                });
            });
        }
        else if (showPageLoader === true) {
            tmcCommon.showLoader();
            $(selector).load(url, data, function (result) {
                loadSuccess(result, callbackFunction, showDivLoader, context, selector);
            });
            if (hidePageLoader === true) {
                tmcCommon.hideLoader();
            }
        }
        else {
            $(selector).load(url, data, function (result) {
                loadSuccess(result, callbackFunction, false, context, selector);
            });
        }

        $.ajaxSetup({ async: true });
    };

    //For Gridview Control
    this.getGridViewDataJson = function (url, gridViewObject, customData, success, error, context) {
        var jsonData;

        if (typeof (gridViewObject) != 'undefined') {
            jsonData = $.toJSON(gridViewObject);
        }
        if (typeof (customData) != 'undefined') {
            customData = $.toJSON(customData);
        }

        //--- To Load everytime refreshed data in grid---
        var datetime = JSON.stringify(new Date());

        $.getJSON(url, { jsonData: jsonData, customData: customData, RefreshData: datetime }, function (result) {
            handleResult(result, success, error, null, context);
        }).error(tmcCommon.handleError);

        $.ajaxSetup({ async: true, cache: false });
    };

    // Common private function
    handleResult = function (result, success, failure, hideLoader, context) {
        if (hideLoader === true) {
            tmcCommon.hideLoader();
        }

        if (result.ResultType === "success") {
            if (success !== null && success !== undefined && typeof (success) == "function") {
                success(result.Data, result.Message, context);
            }
        }
        else if (jsonResult.ResultType == "sessiontimedout") {
            tmcCommon.handleSessionTimeOut(jsonResult.Data);
        }
        else if (result.ResultType === "failure") {
            if (failure !== null && failure !== undefined && typeof (failure) == "function") {
                failure(result.Message, result.ValidationResult, context);
            }
        }
        else if (result.ResultType === "error") {
            tmcCommon.handleError();
        }
    };

    // Common private function
    loadSuccess = function (result, callback, showLoader, context, selector) {
        try {
            var jsonResult = $.parseJSON(result);

            if (jsonResult.ResultType == "error") {
                tmcCommon.handleError();
            }
            else if (jsonResult.ResultType == "sessiontimedout") {
                $(selector).hide();
                tmcCommon.handleSessionTimeOut(jsonResult.Data);
            }
            else {
                if (callback != null && callback != undefined) {
                    if (showLoader === true) {
                        $('#partialviewLoader').fadeIn('normal');
                    }
                    callback(context);
                }
            }
        }
        catch (ex) {
            if (callback != null && callback != undefined) {
                if (showLoader === true) {
                    $('#partialviewLoader').fadeIn('slow');
                }
                callback(context);
            }
        }
    };
};