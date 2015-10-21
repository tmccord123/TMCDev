var productEditor = new function () {
    $(document).ready(function () {
      // $("#divProductEditorContent").hide();
        $('#addUpdateProduct').click(function () {
           // HideHomePageAndShowContentPage(true, true);
            productEditor.CreateEditProduct();
            $("#divProductEditorContent").show();
            productEditor.isEditMode = false;
            productEditor.setProductFields();
        });
    });
    this.setProductFields = function () {
        if (window.frames['iFrameHelpEditor'].document) {
            window.frames['iFrameHelpEditor'].document.getElementById('CE_ftbFieldValue_ID').setHTML($("#lblProductContent").html());
        }
        else if (window.frames['iFrameHelpEditor'].contentDocument) {
            window.frames['iFrameHelpEditor'].contentDocument.getElementById('CE_ftbFieldValue_ID').setHTML($("#lblProductContent").html());
        }
        //if (true) {

        //    var dataResponse = {
        //        helpMasterID: $("#hdnSelectedHelpMaster").val(),
        //        version: Version.Current
        //    };

        //    var actionUrl = $('#divGetHelpDetails').attr('href');
        //    var functionSuccess = helpEditor.showEditModeFields;

        //    service = new wikihelpDataService();
        //    service.ajaxPost(actionUrl, JSON.stringify(dataResponse), functionSuccess, false);
        //}
        
    };



    this.setCouponForCreate = function () {
        //document.getElementById('divCouponEdit').style.display = '';
        // if ($("#lblHelpMessage")) {
        //    $("#lblHelpMessage").html('');
        //}
    };

    this.setCouponFieldsBlank = function () {
        if (window.frames['iFrameHelpEditor'].document) {
             //window.frames['iFrameHelpEditor'].document.getElementById('txtTitle').value = '';
            try {
                window.frames['iFrameHelpEditor'].document.getElementById('CE_ftbFieldValue_ID').SetHTML(' ');
            }
            catch (exception) { }
        }
        else if (window.frames['iFrameHelpEditor'].contentDocument) {
          //   window.frames['iFrameHelpEditor'].contentDocument.getElementById('txtTitle').value = '';
            try {
                window.frames['iFrameHelpEditor'].contentDocument.getElementById('CE_ftbFieldValue_ID').SetHTML(' ');
            }
            catch (exception) { }
        }
    };

    this.   CreateEditProduct = function () {
        productEditor.isCreateCoupon = true;
        this.setCouponForCreate();
        this.setCouponFieldsBlank();
        this.setProductEditorHeight();

        //hide All workflow header Buttons.
        //this.HideWorkflowHeaderButtons();  
    };



    this.setProductEditorHeight = function () {
        var helpEditorHeight = $('#divProductContent').height();

        var cuteEditorHeight;
        if (productEditor.isCreateHelp == true) {
            cuteEditorHeight = helpEditorHeight;// - 220;
        }
        else {
            cuteEditorHeight = helpEditorHeight;//- 170;
        }

        //cuteEditorHeight = 500;
        if (window.frames['iFrameHelpEditor'].document) {
            window.frames['iFrameHelpEditor'].document.getElementById('CE_ftbFieldValue_ID').SetHeight(cuteEditorHeight);
            window.frames['iFrameHelpEditor'].document.getElementById('CE_ftbFieldValue_ID').SetHeight(cuteEditorHeight + "px");
        }
        else {
            window.frames['iFrameHelpEditor'].contentDocument.getElementById('CE_ftbFieldValue_ID').SetHeight(cuteEditorHeight);
            window.frames['iFrameHelpEditor'].contentDocument.getElementById('CE_ftbFieldValue_ID').SetHeight(cuteEditorHeight + "px");
        }
    }


    // save Help Section starts
    $('#btnSaveCoupon').click(function (e) {
        //var dataResponse = {
        //    ProductID: 1,
        //    Name: "sdf",
        //    SeoTitle: "PayTM",
        //    SiteURL: "",
        //    ImageUrl: "",
        //    Description: "sdf",
        //    Content: "",
        //    ContentText: "sdfasdfsdf"
        //};

        //$.ajax({
        //    type: 'POST',
        //    cache: 'false',
        //    contentType: 'application/json; charset=utf-8',
        //    data: JSON.stringify(dataResponse),
        //    dataType: 'text',
        //    url: "/Products/CreateHelp",
        //    success: function () { },
        //    error: function () { }
        //});  
        
        e.preventDefault();
        var isValidHelpInfo = true // helpEditor.validateHelpFields();
        if (isValidHelpInfo == true) {
            productEditor.isEditMode = false;
            productEditor.isCreateHelp = true
            var couponDetailID =1// $("#hdnHelpDetailID").val();
            var helpCode = '';
            var couponTitle = "PayTM" //elpEditor.getHelpTitle();
            var couponMasterContent = productEditor.getCouponContent();
            var couponPlainText = productEditor.getCouponPlainText();
            var dataResponse = { 
                ProductID: couponDetailID,
                Name: "sdf",
                SeoTitle: couponTitle,
                SiteURL: "",
                ImageUrl: "",
                Description: "sdf",
                Content: couponMasterContent, 
                ContentText: couponPlainText
            };

            var actionUrl;
            var functionSuccess;

            if (productEditor.isCreateHelp == true) {
                actionUrl = $('#divCreateCoupon').attr('href');
                functionSuccess = productEditor.helpCreateSuccess;
            }
            //else {
            //    actionUrl = $('#divUpdateHelp').attr('href');
            //    functionSuccess = helpEditor.helpUpdateSuccess;
            //}

            $.ajax({
                type: 'POST',
                cache: 'false',                
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(dataResponse),
                dataType: 'json',
                url: actionUrl,
                success: function () { },
                error: function () { }
            });
            $("#divProductEditorContent").hide();
            window.location.href = window.location.href;
            service = new tmcDataService();
            //service.ajaxPost(actionUrl, JSON.stringify(dataResponse), functionSuccess, false);
        }
        
        //return false;
    });

    this.getCouponPlainText = function () {
        var plainText = document.createElement("div");
        plainText.innerHTML = productEditor.getCouponContent();
        if (plainText.innerText) {
            return plainText.innerText;
        }
        else if (plainText.textContent) {
            return plainText.textContent;
        }
        else {
            return '';
        }
    };

    this.getCouponContent = function () {
        if (window.frames['iFrameHelpEditor'].document) {
            return window.frames['iFrameHelpEditor'].document.getElementById('CE_ftbFieldValue_ID').getHTML();
        }
        else {
            return window.frames['iFrameHelpEditor'].contentDocument.getElementById('CE_ftbFieldValue_ID').getHTML();
        }
    };    // save Help Section ends
}

