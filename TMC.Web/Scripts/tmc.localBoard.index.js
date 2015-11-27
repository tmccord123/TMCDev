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
        $(window).scroll(function () {
            if ($(window).scrollTop() == $(document).height() - $(window).height()) {
                context.GetData();
            }
        });
    };


    this.GetData = function () {        
        $.ajax({
            type: 'GET',
            url: '/LocalBoard/GetListingsData',
            data: {
                "pageindex": 1,
                "pagesize": 1,
                "cityId": 1,
                "categoryId": 1,
                "placeId":1
            },
            dataType: 'html',
            success: function (data) {
                if (data != null) {
                    $("#listingContainer").append(data);
                }
            }
            ,
            beforeSend: function () {
                $("#listingProgress").show();
            },
            complete: function () {
                $("#listingProgress").hide();
            },
            error: function () {
                alert("Error while retrieving data!");
            }
        });
    }

    this.loadListingDataSuccess = function()
    {

    }
}
