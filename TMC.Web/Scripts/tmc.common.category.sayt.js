/// <reference path='..\jquery-1.5.1.js' />
/// <reference path='..\tmc.common.js' />
/// <reference path='..\tmc.dataService.js' />

function CategorySayt() {


    var context = this;

    this.messages = {};
    this.dialogBoxLabels = {};
    this.actionLinks = {};
    this.categoryUrl = tmcCommon.serviceBase + "category/";//todo put in constants
    this.htmlFieldPrefix = '';
    this.controlId = "";
    this.selectCallBack = null;
    
    this.initialize = function () {       
        /* Categories autocomplete */
        $(context.controlId).autocomplete({
            source: function (request, response) {
                $.ajax({
                    //method: 'GET',
                    url: context.categoryUrl + $(context.controlId).val(),
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
                $(context.selectedCategoryName).val(ui.item.label);
                $(context.selectedCategoryId).val(ui.item.id);
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
