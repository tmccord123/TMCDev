﻿var addEditListing;
function AddEditListing() {
    var context = this;
    
    $(document).ready(function () {
        $(".nav-tabs a").click(function () {
            $(this).tab('show');
        });
        $('.nav-tabs a').on('shown.bs.tab', function (event) {
            var x = $(event.target).text();         // active tab
            var y = $(event.relatedTarget).text();  // previous tab
            $(".act span").text(x);
            $(".prev span").text(y);
        });
        

/*        $('#myTabs a[href="#profile"]').tab('show') // Select tab by name
        $('#myTabs a:first').tab('show') // Select first tab
        $('#myTabs a:last').tab('show') // Select last tab
        $('#myTabs li:eq(2) a').tab('show') // Select third tab (0-indexed)*/

    });
    this.setDataFields = function () {
        
         
        
    };

    this.showNextPrevTab = function (tabIndex) { 
        $('.nav-tabs li:eq(' + tabIndex + ') a').tab('show'); // Select third tab (0-indexed)*/
    };




    this.onAddEditListingSuccessCallBack = function (data, message) {
        alert("Iamn dsfe");
        debugger;
        //tmcCommon.hideLoader();
        //$.validator.unobtrusive.parse("#" + context.formId);
        $("#hdnListingId").val(data);
        //tmcDialog.showMessageBox({
        //    header: context.messageBoxSuccessHeader,
        //    message: message,
        //    isHtml: false,
        //    buttonText: context.messageBoxButtonOk,
        //    callback: function () {
        //        window.location.href = data;
        //    }
        //});
    };
}

