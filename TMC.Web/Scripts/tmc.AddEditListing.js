var addEditListing;
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
        
        context.currentTabIndex = 0;
        if (window.location.hash) {
            var hash = window.location.hash.substring(1);
            //alert("hash detected as " + hash);
            context.showNextPrevTab(context.getTabIndex(hash));
        }
    });

    this.initialize = function () {

    };

    //var self = this;
       $(window).bind("hashchange", function() {
            var hash = window.location.hash.substring(1);
           //alert("hash changed to " + hash);
            //context.showNextPrevTab(context.getTabIndex(hash));
        }); 
    
    

   /* this.onHashChange = function () {
        var hash = window.location.hash.substring(1);
        alert("hash changed to " + hash);
        var url = 'http://localhost:3333/' + hash.substring(1);
        /* $.get(url, function (data) {
            $('#content').html(data);
        });#1#
    };*/
    this.setDataFields = function () {
        
    };

 
    
    this.tablist = [ "generalInfo",  "contactDetails","keyCategories","serviceAreas","paymentModes","media"];

    this.showNextPrevTab = function (tabIndex) {
        window.location.hash = context.tablist[tabIndex];
        context.currentTabIndex = tabIndex;
        $('.nav-tabs li:eq(' + tabIndex + ') a').tab('show'); // Select third tab (0-indexed)*/
    };

    this.getTabIndex = function (hash) {
        var retVal = 0;
        context.tablist.forEach(function(listItem , index) {
            if (listItem === hash) {
                retVal=  index;
            }
        });
        return retVal;
    };


    this.onAddEditListingSuccessCallBack = function (data, message) {
        alert(message);
        
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
    
    //Add Categories
    this.onSelectedCategoryCallBack = function () {
        //alert("I am received" + $(context.categoryIdControlId).val());
    };

    //Add service areas to listing success call back
    this.onSelectedAddCityCallBack = function () {
        alert("I am received" + $(context.cityIdControlId).val());
    };

}

