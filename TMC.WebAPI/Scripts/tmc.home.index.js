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

        tmcCommon.attachEvent(document, 'click', '#btnSearchMain', function () {
            var listingUrl = '..//localboard/Index/' + $(context.cityNameControlId).val() + '/' + $(context.categoryNameControlId).val() + '/' + $(context.cityIdControlId).val() + '/' + $(context.categoryIdControlId).val() + '/' + $(context.placeIdControlId).val();
           
            window.location.href = listingUrl;
        });
    };

}
