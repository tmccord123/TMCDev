/// <reference path='..\jquery-1.5.1.js' />
/// <reference path='..\tmc.common.js' />
/// <reference path='..\tmc.dataService.js' />

var localBoardIndex;

function LocalBoardIndex() {


    var context = this;

    this.messages = {};
    this.dialogBoxLabels = {};
    this.actionLinks = {};


    this.initialize = function () {
        //tmcCommon.attachEvent(document, 'click', '#btnSearchMain', function () {
        //    window.location.href = '..//localboard/Index/' + $('#hdnCityName').val() + '/' + $('#hdnCategoryName').val() + '/' + $('#hdnCityId').val() + '/' + $('#hdnCategoryId').val();
        //});
    };

}
