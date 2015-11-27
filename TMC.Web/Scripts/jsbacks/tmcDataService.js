/// <reference path="jquery-1.5.1.js" />
///<reference path="wikihelp.common.js" />

function tmcDataService() {

    this.ajaxSubmitSuccessHandler = '';
    this.ajaxFormSuccessHandler = '';
    this.ajaxPostSuccessHandler = '';

    // ajax call
    this.getJSONData = function (query, ajaxActionUrl, success, failure, showLoader, hideLoader) {

        var url = ajaxActionUrl;

        if (showLoader === true) {
            wikihelpCommon.showLoader();
        }

        $.getJSON(url, query, function (result) {
            handleResult(result, success, failure, hideLoader);
        }).error(function (message) {
            wikihelpCommon.handleError(message);
        });
    };

    this.ajaxPost = function (url, data, success, showLoader) {
        if (showLoader === true) {
            wikihelpCommon.showLoader();
        }

        tmcDataService.ajaxPostSuccessHandler = success;

        $.ajax({
            type: 'POST',
            cache: 'false',
            contentType: 'application/json; charset=utf-8',
            data: data,
            dataType: 'json',
            url: url,
            success: ajaxPostSuccess,
            error: wikihelpCommon.handleError
        });
    }

    this.ajaxPostGetText = function (url, data, success, showLoader) {
        if (showLoader === true) {
            wikihelpCommon.showLoader();
        }

        tmcDataService.ajaxPostSuccessHandler = success;

        $.ajax({
            type: 'POST',
            cache: 'false',
            data: data,
            dataType: 'text',
            url: url,
            success: ajaxPostSuccess,
            error: wikihelpCommon.handleError
        });
    }

    // error handled ajax submit
    this.ajaxSubmit = function (formselector, url, data, beforeSubmit, success, showLoader) {

        if (showLoader === true) {
            wikihelpCommon.showLoader();
        }

        tmcDataService.ajaxSubmitSuccessHandler = success;

        var options = {
            url: url,
            cache: 'false',
            data: data,
            dataType: 'json',
            beforeSubmit: beforeSubmit,
            success: ajaxSubmitSuccess,
            error: wikihelpCommon.handleError
        };

        $(formselector).ajaxSubmit(options);
    };

    // error handled ajax form
    this.ajaxForm = function (formselector, beforeSubmit, success) {

        tmcDataService.ajaxFormSuccessHandler = success;

        var options = {
            dataType: 'json',
            beforeSubmit: beforeSubmit,
            success: ajaxFormSuccess,
            error: wikihelpCommon.handleError
        };

        $(formselector).ajaxForm(options);
    };

    // error handled ajax form
    this.load = function (selector, url, data, asyncMode, showPageLoader, hidePageLoader, showDivLoader, showSlideDownEffect, callbackFunction) {

        $.ajaxSetup({
            async: asyncMode,
            error: wikihelpCommon.handleError
        });

        if (showDivLoader === true && showSlideDownEffect === true && showPageLoader === false) {
            $(selector).html('');
            $(selector).append('<div id="partialviewLoader" class="partialContentLoader"></div>');

            $('#partialviewLoader').fadeOut('normal', function () {
                $(selector).load(url, data, function (result) {
                    $(selector).addClass('displayNone');
                    $(selector).hide().slideDown(1500);
                    loadSuccess(result, callbackFunction, showDivLoader);
                });
            });
        }
        else if (showDivLoader === true && showSlideDownEffect === false && showPageLoader === false) {
            $(selector).empty();
            $(selector).append('<div id="partialviewLoader" class="partialContentLoader"></div>');

            $('#partialviewLoader').fadeOut('normal', function () {
                $(selector).load(url, data, function (result) {
                    loadSuccess(result, callbackFunction, showDivLoader);
                });
            });
        }
        else if (showPageLoader === true) {
            wikihelpCommon.showLoader();
            $(selector).load(url, data, function (result) {
                loadSuccess(result, callbackFunction, showDivLoader);
            });
            if (hidePageLoader === true) {
                wikihelpCommon.hideLoader();
            }
        }
        else {
            $(selector).load(url, data, function (result) {
                loadSuccess(result, callbackFunction);
            });
        }

        $.ajaxSetup({ async: true });

    };

    // Common private function
    handleResult = function (result, success, failure, hideLoader) {
        //debugger;
        if (hideLoader === true) {
            wikihelpCommon.hideLoader();
        }
        if (result.resultType == "success") {
            success(result);
        }
        else if (result.resultType == "error") {
            if (result.data == WikiHelpErrorCode.SessionTimeout) {
                // failure(result.message);
                window.location.href = '/Home/Index';
            }
        }
        //        if (result.message == "sorry, but you were logged out. 223") {
        //            failure(result.message);
        //        }
        //        else {
        //            success(result);
        //        }
        //        if (result.resultType == "success") {
        //            if (success) {
        //                success(result.data, result.message);
        //            }
        //        }
        //        else if (result.resultType == "failure") {
        //            if (failure) {
        //                failure(result.message, result.ValidationResult);
        //            }
        //        }
        //        else if (result.resultType == "error") {
        //            wikihelpCommon.overrideConfirmNavigation = false;
        //            window.location.href = $("#divErrorRedirect").attr("href");
        //        }
        //        else if (result.resultType == "redirect") {
        //            wikihelpCommon.overrideConfirmNavigation = false;
        //            window.location.href = result.redirectUrl;
        //        }
    };

    ajaxPostSuccess = function (result) {
        if (result.resultType == "error") {
            if (result.data == WikiHelpErrorCode.SessionTimeout) {
                //failure(result.message);
                window.location.href = '/Home/Index';
            }
        }
        else {
            tmcDataService.ajaxPostSuccessHandler(result);
        }
    }


    // Common private functions
    ajaxSubmitSuccess = function (result) {

        if (result.resultType == "error") {
            wikihelpCommon.overrideConfirmNavigation = false;
            window.location.href = $("#divErrorRedirect").attr("href");
        }
        else {
            tmcDataService.ajaxSubmitSuccessHandler(result);
        }
    };

    // Common private function
    ajaxFormSuccess = function (result) {

        if (result.resultType == "error") {
            wikihelpCommon.overrideConfirmNavigation = false;
            window.location.href = $("#divErrorRedirect").attr("href");
        }
        else {
            tmcDataService.ajaxFormSuccessHandler(result);
        }
    };

    // Common private function
    loadSuccess = function (result, callback, showLoader) {

        try {
            var jsonResult = $.parseJSON(result);

            if (jsonResult.resultType == "error") {
                wikihelpCommon.overrideConfirmNavigation = false;
                window.location.href = $("#divErrorRedirect").attr("href");
            }
            else {
                if (callback != null && callback != undefined) {
                    if (showLoader === true) {
                        $('#partialviewLoader').fadeIn('normal');
                    }
                    callback();
                }
            }
        }
        catch (ex) {
            if (callback != null && callback != undefined) {
                if (showLoader === true) {
                    $('#partialviewLoader').fadeIn('slow');
                }
                callback();
            }
        }
    };

};

WikiHelpErrorCode = {
    SessionTimeout: "SESSIONTIMEOUT"
}