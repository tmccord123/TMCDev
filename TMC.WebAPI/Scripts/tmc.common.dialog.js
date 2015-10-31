var tmcDialog = {
    //Message box
    showMessageBox: function (options) {
        var messageBoxOptions = $.extend({
            header: 'Header',
            message: 'Message',
            showCloseButton: false,
            isHtml: false,
            messageBoxContext: null,
            buttonText: 'Ok',
            callback: undefined
        }, options), $tmcDialogMessageBoxHeader, $tmcDialogMessageBoxBody, $tmcDialogMessageBoxCloseButton, $tmcDialogMessageBoxOkButton;

        $tmcDialogMessageBoxHeader = $("#tmcDialogMessageBox").find('#tmcDialogMessageBoxHeader');
        $tmcDialogMessageBoxBody = messageBoxOptions.isHtml ?
                                   $("#tmcDialogMessageBox").find('#tmcDialogMessageBoxBody') :
                                   $("#tmcDialogMessageBox").find('#tmcDialogMessageBoxBody p');
        $tmcDialogMessageBoxCloseButton = $("#tmcDialogMessageBox").find('button.close');
        $tmcDialogMessageBoxOkButton = $("#tmcDialogMessageBox").find('#tmcDialogMessageBoxOkButton');

        $tmcDialogMessageBoxHeader.html(messageBoxOptions.header);
        $tmcDialogMessageBoxBody.html(messageBoxOptions.message);

        if (messageBoxOptions.showCloseButton) {
            $tmcDialogMessageBoxCloseButton.show();
        }
        else {
            $tmcDialogMessageBoxCloseButton.hide();
        }
        
        $tmcDialogMessageBoxOkButton.html(messageBoxOptions.buttonText);
        $tmcDialogMessageBoxOkButton.off("click");
        $tmcDialogMessageBoxOkButton.click(function () {
            $("#tmcDialogMessageBox").modal('hide');

            if (typeof messageBoxOptions.callback !== "undefined") {
                messageBoxOptions.callback(messageBoxOptions.messageBoxContext);
            }
        });

        $("#tmcDialogMessageBox").modal({
            show: true,
            backdrop: 'static',
            keyboard: false
        });
    },

    //confirm box
    showConfirmBox: function (options) {
        var messageBoxOptions = $.extend({
            header: 'Header',
            message: 'Message',
            showCloseButton: true,
            isHtml: false,
            confirmBoxContext: null,
            okButtonText: 'Ok',
            cancelButtonText: 'Cancel',
            okCallback: undefined,
            cancelCallback: undefined
        }, options), $tmcDialogConfirmBoxHeader, $tmcDialogConfirmBoxBody, $tmcDialogConfirmBoxCloseButton,
        $tmcDialogConfirmBoxOkButton, $tmcDialogConfirmBoxCancelButton;

        $tmcDialogConfirmBoxHeader = $("#tmcDialogConfirmBox").find('#tmcDialogConfirmBoxHeader');
        $tmcDialogConfirmBoxBody = messageBoxOptions.isHtml ?
                                   $("#tmcDialogConfirmBox").find('#tmcDialogConfirmBoxBody') :
                                   $("#tmcDialogConfirmBox").find('#tmcDialogConfirmBoxBody p');
        $tmcDialogConfirmBoxCloseButton = $("#tmcDialogConfirmBox").find('button.close');
        $tmcDialogConfirmBoxOkButton = $("#tmcDialogConfirmBox").find('#tmcDialogConfirmBoxOkButton');
        $tmcDialogConfirmBoxCancelButton = $("#tmcDialogConfirmBox").find('#tmcDialogConfirmBoxCancelButton');

        $tmcDialogConfirmBoxHeader.html(messageBoxOptions.header);
        $tmcDialogConfirmBoxBody.html(messageBoxOptions.message);

        if (messageBoxOptions.showCloseButton) {
            $tmcDialogConfirmBoxCloseButton.show();
        }
        else {
            $tmcDialogConfirmBoxCloseButton.hide();
        }

        $tmcDialogConfirmBoxOkButton.html(messageBoxOptions.okButtonText);
        $tmcDialogConfirmBoxOkButton.off("click");
        $tmcDialogConfirmBoxOkButton.click(function () {
            $("#tmcDialogConfirmBox").modal('hide');

            if (typeof messageBoxOptions.okCallback !== "undefined") {
                messageBoxOptions.okCallback(messageBoxOptions.confirmBoxContext);
            }
        });

        $tmcDialogConfirmBoxCancelButton.html(messageBoxOptions.cancelButtonText);
        $tmcDialogConfirmBoxCancelButton.off("click");
        $tmcDialogConfirmBoxCancelButton.click(function () {
            $("#tmcDialogConfirmBox").modal('hide');

            if (typeof messageBoxOptions.cancelCallback !== "undefined") {
                messageBoxOptions.cancelCallback(messageBoxOptions.confirmBoxContext);
            }
        });

        $("#tmcDialogConfirmBox").modal({
            show: true,
            backdrop: 'static',
            keyboard: false
        });
    }
};
