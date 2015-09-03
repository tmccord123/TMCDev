/// <reference path="jquery-1.5.1.js" />
var tmcCommon = new function () {
    this.baseUrl = "";
    this.notificationTimeOut = "";
    this.emailRegularExpression = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
    this.overrideConfirmNavigation = false;
    this.dateTimeFormat = "mm/dd/yyyy - h:MM TT";
    this.dateFormat = "mm/dd/yyyy";
    this.notificationDivTimeOut;
    this.pollingInterval = "";
    this.autoLockPollingInterval = "";
    this.renderedMainContentHeight = 0;
    this.emptyOrgChartItemText = '';
    this.locationMapZoomLevel = 8;
    this.resizeHeightKey = 'resizeHeight';
    this.resizeWidthKey = 'resizeWidth';
    this.navigationOverFlowText = '';
    this.carouselDelay = '';
    this.toolTipHideDelay = 5000;

    this.getViewPortHeight = function () {

        var viewportHeight; // variable to store vertical distance value of browser-specific visible area for web page.

        if (self.innerHeight) // all except Internet Explorer
        {
            viewportHeight = self.innerHeight;
        }
        else if (document.documentElement && document.documentElement.clientHeight) {
            // Explorer 6 Strict Mode
            viewportHeight = document.documentElement.clientHeight;
        }
        else if (document.body) // other Explorers
        {
            viewportHeight = document.body.clientHeight;
        }

        return viewportHeight;
    };

    this.getViewPortWidth = function () {

        var viewportWidth; // variable to store vertical distance value of browser-specific visible area for web page.

        if (self.innerWidth) // all except Internet Explorer
        {
            viewportWidth = self.innerWidth;
        }
        else if (document.documentElement && document.documentElement.clientWidth) {
            // Explorer 6 Strict Mode
            viewportWidth = document.documentElement.clientWidth;
        }
        else if (document.body) // other Explorers
        {
            viewportWidth = document.body.clientWidth;
        }

        return viewportWidth;
    };

    this.setMainContentContainerHeight = function (viewportHeight) {
        //calculate sum of rendered heights of header and footer.
        var headerHeight = $('header').height();
        var footerHeight = $('footer').height();
        //calculate browser rendered height for main content(or container) 
        var availableViewPortHeight = viewportHeight - headerHeight - 25;

        this.renderedMainContentHeight = availableViewPortHeight - footerHeight;

        if ($('.containerMain .tabs-nav > .tab-content > .global-pad').length > 0) {
            $('.containerMain .tabs-nav > .tab-content > .global-pad').css("min-height", (this.renderedMainContentHeight) + "px");
        }
        else {
            $('.containerMain').css("min-height", (this.renderedMainContentHeight) + "px");
        }
    };

    /*---- Show Hide left Menu Function----*/
    this.toggleContainer = function () {
        if (document.getElementById('leftNav').style.display == 'none') {
            document.getElementById('leftNav').style.display = '';
            $('#leftPanel').removeClass('leftNavExpand').addClass('leftNavCollapse');
            $('#containerMain').addClass('posRes');
        }
        else {
            document.getElementById('leftNav').style.display = 'none';
            $('#leftPanel').removeClass('leftNavCollapse').addClass('leftNavExpand');
            $('#containerMain').removeClass('posRes');
        }
        PubSub.publish(this.resizeWidthKey);
    };

    this.showNotification = function (options) {
        var notificationOptions = $.extend({
            message: 'message',
            duration: 5000,
            type: 'success' // others are info, warning and error
        }, options), $divNotification = $('#divNotification'), $divMessage;

        switch (notificationOptions.type) {
            case 'success':
                $divMessage = $divNotification.find('.alert-success');
                break;
            case 'info':
                $divMessage = $divNotification.find('.alert-info');
                break;
            case 'warning':
                $divMessage = $divNotification.find('.alert-warning');
                break;
            case 'error':
                $divMessage = $divNotification.find('.alert-danger');
                break;
            default:
                $divMessage = $divNotification.find('.alert-success');
                break;
        }

        $divMessage.html(notificationOptions.message)
        $divMessage.fadeIn();

        setTimeout(function () {
            $divMessage.fadeOut();
        }, notificationOptions.duration);
    };

    this.showLoader = function () {
        $("#pageLoaderModal").modal({
            show: true,
            backdrop: 'static',
            keyboard: false
        });
    };

    this.hideLoader = function () {
        $("#pageLoaderModal").modal('hide');
    };

    this.showDivLoader = function (containerDivElement) {
        if ($('#' + containerDivElement).find('#partialviewLoader').length === 0) {
            $('#' + containerDivElement).append('<div id="partialviewLoader" class="partialContentLoader"></div>');
            $('#' + containerDivElement).find('div:not("#partialviewLoader"):first').addClass('displayNone');
        }
    };

    this.hideDivLoader = function (containerDivElement) {
        $('#' + containerDivElement).find('#partialviewLoader').remove();
        $('#' + containerDivElement).find('div:not("#partialviewLoader"):first').removeClass('displayNone');
    };

    //Method to set height of common and page specific elements by calling a js method for a particular page such as plan preview
    this.setHeightAsPerResolution = function () {
        var viewportHeight = tmcCommon.getViewPortHeight();
        tmcCommon.setMainContentContainerHeight(viewportHeight);
    };

    this.showStickyNote = function (text) {
        if (text == null || text == undefined || text.trim() == '') {
            text = "Notification";
        }

        $('#stickyNote').remove();
        $('<div />',
        {
            'id': 'stickyNote',
            'class': 'stickyNote',
            'text': text
        }).prependTo("body").fadeIn('fast');
    };

    this.hideStickyNote = function () {
        $('#stickyNote').slideUp('fast');
    };

    this.isNotNullOrEmpty = function (value) {
        var retVal = false;

        retVal = (value !== null) && (value !== undefined);

        if (retVal && value.hasOwnProperty('length')) {
            retVal = retVal && (value.length > 0);
        }

        return retVal;
    };

    this.initializePlaceHolders = function () {
        var placeholderSupport, input;
        placeholderSupport = ('placeholder' in document.createElement('input'));

        if (!placeholderSupport) {
            $('[placeholder]').focus(function () {
                input = $(this);
                if (input.val() == input.attr('placeholder')) {
                    input.val('');
                    input.removeClass('placeholder');
                }
            }).blur(function () {
                input = $(this);
                if (input.val() == '' || input.val() == input.attr('placeholder')) {
                    input.addClass('placeholder');
                    input.val(input.attr('placeholder'));
                }
            }).blur();
        }
    };

    this.showLocationMap = function (locationMapOptions) {
        var mapOptions, map, markerOptions, marker;

        coordinatesHandler = new CoordinatesHandler();

        mapOptions = {
            center: new google.maps.LatLng(locationMapOptions.latitude, locationMapOptions.longitude),
            zoom: this.locationMapZoomLevel,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        //jQuery not working with google map api. Using document.getElementById instead of jQuery selector
        map = new google.maps.Map(document.getElementById(locationMapOptions.contentDivId), mapOptions);

        markerOptions = {
            position: new google.maps.LatLng(locationMapOptions.latitude, locationMapOptions.longitude),
            map: map,
            animation: google.maps.Animation.DROP,
            title: locationMapOptions.markerTitle
        }
        marker = new google.maps.Marker(markerOptions);
    };

    this.showPathMap = function (pathMapOptions) {
        var mapOptions, map, markerOptionsFrom, markerFrom, markerOptionsTo, markerTo, latitudeCenter,
        longitudeCenter, iconBase, startMarkerIcon, endMarkerIcon, pathCoordinates, polyline, bounds, strokeColor;

        iconBase = 'http://maps.google.com/mapfiles/';
        startMarkerIcon = iconBase + 'dd-start.png';
        endMarkerIcon = iconBase + 'dd-end.png'
        strokeColor = '#FF4500';

        latitudeCenter = (pathMapOptions.latitudeFrom + pathMapOptions.latitudeTo) / 2;
        longitudeCenter = (pathMapOptions.longitudeFrom + pathMapOptions.longitudeTo) / 2;

        mapOptions = {
            center: new google.maps.LatLng(latitudeCenter, longitudeCenter),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        //jQuery not working with google map api. Using document.getElementById instead of jQuery selector
        map = new google.maps.Map(document.getElementById(pathMapOptions.contentDivId), mapOptions);

        markerOptionsFrom = {
            position: new google.maps.LatLng(pathMapOptions.latitudeFrom, pathMapOptions.longitudeFrom),
            map: map,
            animation: google.maps.Animation.DROP,
            title: pathMapOptions.locationFromHelpText,
            icon: startMarkerIcon
        }
        markerFrom = new google.maps.Marker(markerOptionsFrom);

        markerOptionsTo = {
            position: new google.maps.LatLng(pathMapOptions.latitudeTo, pathMapOptions.longitudeTo),
            map: map,
            animation: google.maps.Animation.DROP,
            title: pathMapOptions.locationToHelpText,
            icon: endMarkerIcon
        }
        markerTo = new google.maps.Marker(markerOptionsTo);

        pathCoordinates = [
		new google.maps.LatLng(pathMapOptions.latitudeFrom, pathMapOptions.longitudeFrom),
		new google.maps.LatLng(pathMapOptions.latitudeTo, pathMapOptions.longitudeTo),
        ];

        polyline = new google.maps.Polyline({
            path: pathCoordinates,
            strokeColor: strokeColor,
            strokeOpacity: 1.0,
            strokeWeight: 2
        });
        polyline.setMap(map);

        bounds = new google.maps.LatLngBounds();

        bounds.extend(pathCoordinates[0]);
        bounds.extend(pathCoordinates[1]);

        map.fitBounds(bounds);
    };

    // returns html decoded data
    this.decodeHTML = function (data) {
        return $('<div />').html(data).text();
    };

    // returns decoded URL 
    this.decodeURL = function (url) {
        return url.replaceAll('&amp;', '&');
    };

    // returns encoded URL 
    this.encodeURL = function (url) {

        var returnURL = url.replaceAll('&amp;', '%26');
        returnURL = returnURL.replaceAll('&', '%26');

        return returnURL;
    };

    // handles click of save button
    this.handleEnterPress = function (formId) {
        $('#' + formId).keypress(function (e) {
            var key;

            if (window.event)
                key = window.event.keyCode; //IE
            else
                key = e.which; //firefox      

            return (key != 13);
        });
    };

    this.resetFormValidationInformation = function (selector) {
        var form = $(selector);

        form.removeData("validator") /* added by the raw jquery.validate plugin */
        form.removeData("unobtrusiveValidation");  /* added by the jquery unobtrusive plugin */

        $.validator.unobtrusive.parse(form);
    };

    // success or failure is handled here
    this.postFormSuccess = function (data, status, xhr, successCallback, failureCallback, validationCallback) {
        if (tmcCommon.isNotNullOrEmpty(xhr.responseJSON)) { // JSON Result
            if (data.ResultType === 'success') {
                if (successCallback !== null && successCallback !== undefined && typeof (successCallback) == "function") {
                    successCallback(data.Data, data.Message);
                }
            }
            else if (data.ResultType === 'failure') {
                if (failureCallback !== null && failureCallback !== undefined && typeof (failureCallback) == "function") {
                    failureCallback(data.Message, data.ValidationResult);
                }
            }
            else if (data.ResultType === 'error') {
                tmcCommon.handleError();
            }
        }
        else { // HTML Result (validation has failed)
            if (validationCallback !== null && validationCallback !== undefined && typeof (validationCallback) == "function") {
                validationCallback(data);
            }
        }
    };

    // exceptions are handled here
    this.handleError = function (xhr, status, message) {
        tmcCommon.overrideConfirmNavigation = false;
        window.location = ErrorRedirectUrl; // to error page
    };

    // handle session time out on ajax calls
    this.handleSessionTimeOut = function (redirectUrl) {
        tmcCommon.hideLoader();
        jccDialog.showMessageBox({
            header: SessionTimedOutHeader,
            message: SessionTimedOutMessage,
            callback: function () {
                tmcCommon.showLoader();
                window.location = redirectUrl;
            }
        });
    };

    this.applyMaxLengthAttribute = function (controlId) {
        var selector = '#' + controlId;
        var controlField = $(selector);
        if (typeof controlField !== 'undefined' && controlField !== null) {
            var maxLengthValue = controlField.attr('data-val-length-max');
            if (typeof maxLengthValue !== 'undefined') {
                //maxLengthValue = parseInt(maxLengthValue, 10) + 1;
                controlField.attr('maxlength', maxLengthValue);
            }
        }
    };

    this.sortDropDownListByText = function (controlId) {

        // Loop for each select element on the page.
        $("#" + controlId).each(function () {
            // Keep track of the selected option.
            var selectedValue = $(this).val();
            // Sort all the options by text. I could easily sort these by val.
            $(this).html($("option", $(this)).sort(function (a, b) {
                return a.text.toUpperCase() == b.text.toUpperCase() ? 0 : a.text.toUpperCase() < b.text.toUpperCase() ? -1 : 1;
            }));
            // Select one option.
            $(this).val(selectedValue);
        });
    };

    this.printHtml = function (htmlToPrint) {
        var printLayout = $.trim($('#printLayout').html()),
            xLeft = window.innerWidth / 8, //Will keep x position from Left.    
            yTop = window.innerHeight / 8,   //This will put your new window on the Top, as Y co-ordinate given '0'. 
            sFeatures = "height=" + window.innerHeight * 0.75 + ",width=" + window.innerWidth * 0.75 + ",left=" + xLeft + ",top=" + yTop + ",status=no,scrollbars=yes,toolbar=no,menubar=yes, location=no, resizable=yes", //This will give all these features to your 
            win = window.open('', "Print", sFeatures), //new opened window.             
            $printLayout = $(printLayout);

        $printLayout.find('#printBody').html(htmlToPrint);

        for (var index = 0; index < $printLayout.length; index++) {
            win.document.write($printLayout.eq(index).clone().wrap('<p>').parent().html());
        }
        win.document.close();
        win.focus();
        win.print();
    };

    this.exportToPDF = function (exportUrl) {
        var xLeft = window.innerWidth / 8, //Will keep x position from Left.    
            yTop = window.innerHeight / 8,   //This will put your new window on the Top, as Y co-ordinate given '0'. 
            sFeatures = "height=" + window.innerHeight * 0.75 + ",width=" + window.innerWidth * 0.75 + ",left=" + xLeft + ",top=" + yTop + ",status=no,scrollbars=yes,toolbar=no,menubar=yes, location=no, resizable=yes", //This will give all these features to your 
            win = window.open(exportUrl, "Print", sFeatures); //new opened window.

        win.document.close();
        win.focus();
    };

    this.setModalWidth = function ($modal, factor) {
        var originalWidth, newWidth, originalMarginLeft, newMarginLeft;

        originalWidth = parseInt($modal.width(), 10);
        newWidth = window.innerWidth * factor;

        if (newWidth < 500) {
            newWidth = 500;
        }

        originalMarginLeft = $modal.css('margin-left');
        newMarginLeft = parseInt(originalMarginLeft, 10) + (originalWidth - newWidth) / 2;

        $modal.css({
            'width': newWidth + 'px',
            'margin-left': newMarginLeft + 'px'
        });
    };
};
