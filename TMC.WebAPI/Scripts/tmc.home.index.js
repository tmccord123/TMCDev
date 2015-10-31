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
            nextText: '',
            pauseOnHover:true,
            after: function () {

            }
        });  

        tmcCommon.attachEvent(document, 'click', '#btnSearchMain', function () {
            var cityId, categoryId, cityName, categoryName;
            cityId = $(context.cityIdControlId).val();
            cityName = $(context.cityNameControlId).val();
            categoryId = $(context.categoryIdControlId).val();
            categoryName = $(context.categoryNameControlId).val();

            if (!$.isNumeric(cityId))
            {
                tmcDialog.showMessageBox({
                    header: "Warning",
                    message: "Please select city.",
                    buttonText: "Ok",
                    callback: function () {
                        
                    }
                });
            }
            else if (!$.isNumeric(categoryId)) {
                tmcDialog.showMessageBox({
                    header: "Warning",
                    message: "Please select category.",
                    buttonText: "Ok",
                    callback: function () {

                    }
                });
            }
            else if ($.isNumeric(cityId) && $.isNumeric(categoryId)) {
                var listingUrl = '..//localboard/Index/' + cityName + '/' + categoryName + '/' + cityId + '/' + categoryId + '/' + $(context.placeIdControlId).val();
                window.location.href = listingUrl;
            }
           
            
        });
    };

}
