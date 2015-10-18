/// <reference path='..\jquery-1.5.1.js' />
/// <reference path='..\tmc.common.js' />
/// <reference path='..\tmc.dataService.js' />

function PlaceSayt() {


    var context = this;

    this.messages = {};
    this.dialogBoxLabels = {};
    this.actionLinks = {};
    this.placeUrl = "..//api/placeAutoComplete/";   
    this.htmlFieldPrefix = '';
    this.controlId = "";
    this.selectCallBack = null;
    
    this.initialize = function () {       
        /* Places autocomplete */
        $(context.controlId).autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: context.placeUrl + $(context.selectedCityDetailsId).val() + $(context.controlId).val(),
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
                $(context.selectedPlaceId).val(ui.item.id);
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
