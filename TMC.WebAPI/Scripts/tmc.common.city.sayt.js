/// <reference path='..\jquery-1.5.1.js' />
/// <reference path='..\tmc.common.js' />
/// <reference path='..\tmc.dataService.js' />

function CitySayt() {


    var context = this;

    this.messages = {};
    this.dialogBoxLabels = {};
    this.actionLinks = {};
    this.cityUrl = "..//api/city/";
    this.citySeperator = ',';
    this.htmlFieldPrefix = '';
    this.controlId = "";
    this.selectCallBack = null;

    this.initialize = function () {       
        /* Cities autocomplete */
        $(context.controlId).autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: context.cityUrl + $(context.controlId).val(),
                    dataType: "json",                   
                    success: function (data) {                        
                        response($.map(data, function (item) {
                            return {
                                label: item.name,
                                id: item.cityId,
                                cityDetails: item.lat + context.citySeperator + item.long + context.citySeperator + item.radius + context.citySeperator
                            };
                        }));
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {               
                $(context.selectedCityName).val(ui.item.label);
                $(context.selectedCityId).val(ui.item.id);
                $(context.selectedCityDetails).val(ui.item.cityDetails);
                if (context.selectCallBack != null)
                {
                    context.selectCallBack();                    
                }
                $("#divPlaces").removeClass("display-none");
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        });       

    };

}
