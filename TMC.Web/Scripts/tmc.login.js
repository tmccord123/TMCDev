var login;
function Login() {
    var context = this;
    
    $(document).ready(function () {
       
    });

    this.initialize = function () {

    };
     

    this.onSuccessfullLoginCallBack = function (data, message) {
        if (data.returnUrl) {
           // alert("login successfull");
            localStorage.setItem('authData', JSON.stringify(data));
            window.location.href = data.returnUrl;
        } else {
            window.location.href = "/";
        }
        
        //tmcCommon.hideLoader();
        //$.validator.unobtrusive.parse("#" + context.formId);
        //$("#hdnListingId").val(data);
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

