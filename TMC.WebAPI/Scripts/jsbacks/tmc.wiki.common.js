var wikihelpCommon = new function () {
    this.overrideConfirmNavigation = false;
    this.notificationTimeOut = "";
    this.renderedMainContentHeight = 0;
    /*---- Show/Hide left section Function----*/
    this.toggleContainer = function () {
        if (document.getElementById('leftNav')) {
            if (document.getElementById('leftNav').style.display == 'none') {
                document.getElementById('leftNav').style.display = '';
                $("#lnkTabCont").removeClass("icon-table-of-content-close");
                $("#lnkTabCont").addClass("icon-table-of-content");
            }
            else {
                document.getElementById('leftNav').style.display = 'none';
                $("#lnkTabCont").removeClass("icon-table-of-content");
                $("#lnkTabCont").addClass("icon-table-of-content-close");
            }
        }
    };

    this.toggleLeftPanel = function () {
        if ($("#leftNav").is(':visible')) {
            $("#leftNav").hide(0);
            $("#ECSpan").parent().removeClass('expand').addClass('expand-collapse');
            $("#ECSpan").removeClass('accrowE').addClass('accrowC');
        }
        else {
            $("#leftNav").show(0);
            $("#ECSpan").parent().removeClass('expand-collapse').addClass('expand');
            $("#ECSpan").removeClass('accrowC').addClass('accrowE');

        }
    };

    this.collapseLeftPanel = function () {
        $("#leftNav").hide(0);
        $("#ECSpan").parent().removeClass('expand').addClass('expand-collapse');
        $("#ECSpan").css("display", "");
        $("#ECSpan").removeClass('accrowE').addClass('accrowC');
    };

    this.hideTOC = function () {
        document.getElementById('leftNav').style.display = '';
        $("#lnkTabCont").removeClass("icon-table-of-content-close");
        $("#lnkTabCont").addClass("icon-table-of-content");
    }

    this.setTOCState = function () {
        if (document.getElementById('leftNav').style.display == 'none') {
            $("#lnkTabCont").removeClass("icon-table-of-content");
            $("#lnkTabCont").addClass("icon-table-of-content-close");
        }
        else {

            $("#lnkTabCont").removeClass("icon-table-of-content-close");
            $("#lnkTabCont").addClass("icon-table-of-content");
        }
    };

    this.selectPreviousNode = function () {
        var helpTree = $("#divHelpTree").dynatree("getTree");
        var node = $("#divHelpTree").dynatree("getActiveNode");
        var selectedHelpMaster = $("#hdnSelectedHelpMaster").val();
        var activeNode = helpTree.getNodeByKey(selectedHelpMaster);
        var prevKey = activeNode.data.prevKey;
        if (prevKey != "-1") {
            $("#divHelpTree").dynatree("getTree").activateKey(prevKey);
        }
    }

    this.selectNextNode = function () {
        var helpTree = $("#divHelpTree").dynatree("getTree");
        //var activeNode = $("#divHelpTree").dynatree("getActiveNode");
        var selectedHelpMaster = $("#hdnSelectedHelpMaster").val();
        var activeNode = helpTree.getNodeByKey(selectedHelpMaster);
        var nextNode;
        nextNode = this.getNextNode(activeNode).data.key;
        $("#divHelpTree").dynatree("getTree").activateKey(nextNode);
    }

    this.getNextNode = function (node) {
        var nextNode;
        var nextNodeFound;
        if (node.getNextSibling()) {
            nextNode = node.getNextSibling();
            if (nextNode.data.isFolder) {
                if (nextNode.hasChildren() == true) {
                    nextNode = nextNode.getChildren()[0];
                    if (nextNode.data.isFolder) {
                        if (nextNode.hasChildren() == true) {
                            nextNode = nextNode.getChildren()[0];
                        }
                    }
                    nextNodeFound = true;
                }
                else {
                    nextNode = this.getNextNode(nextNode);
                }
            }
            else {
                nextNodeFound = true;
            }
        }
        else {
            var parentNode = node.getParent();
            if (parentNode.data.key == "_1") {
                nextNode = null;
            }
            else {
                nextNode = this.getNextNode(parentNode);
            }
        }
        return nextNode;
    }

    this.showLoader = function () {
        // $("div.overlayLoad").fadeIn([50000], [90])
        $("#divLoading").show();
    };

    this.showDivLoader = function (containerDivElement) {
        $('#' + containerDivElement).append('<div id="partialviewLoader" class="partialContentLoader"></div>');
        $('#' + containerDivElement).find('div:not("#partialviewLoader"):first').addClass('displayNone');
    };

    this.hideDivLoader = function (containerDivElement) {
        $('#' + containerDivElement).find('#partialviewLoader').remove();
        $('#' + containerDivElement).find('div:not("#partialviewLoader"):first').removeClass('displayNone');
    };

    this.hideLoader = function () {
        $("div.overlayLoad").fadeOut([5000], [20]);
        $("#divLoading").hide();
    };

    this.handleError = function (message) {

    };

    //Method to set height of content
    this.setHeightAsPerResolution = function () {
        var viewportHeight = wikihelpCommon.getViewPortHeight();
        wikihelpCommon.setMainContentContainerHeight(viewportHeight);

    };

    this.getViewPortHeight = function () {

        var viewportHeight; // variable to store vertical distance value of browser-specific visible area for web page.

        if (self.innerHeight) // all except Internet Explorer
        {
            viewportHeight = self.innerHeight;
        }
        else if (document.documentElement && document.documentElement.clientHeight) {
            // Explorer 6 Strict Mode
            viewportHeight = document.documentElement.clientHeight;
        }
        else if (document.body) // other Explorers
        {
            viewportHeight = document.body.clientHeight;
        }

        return viewportHeight;
    };

    this.setMainContentContainerHeight = function (viewportHeight) {
        var headerHeight = $('#header').height();
        var footerHeight = $('#footer').height();
        var helpMenuHeight = $('#divHelpMenu').height();
        //calculate browser rendered height for main content 
        var availableViewPortHeight = viewportHeight - headerHeight - footerHeight;

        this.renderedMainContentHeight = availableViewPortHeight;

        $('#divBody').css("height", (availableViewPortHeight) + "px");
        $('#ECSpan').css("height", (availableViewPortHeight - footerHeight - helpMenuHeight) + "px");

        if ((typeof homeViewerIndex != 'undefined') && (typeof homeViewerIndex.setHelpContentHeight != 'undefined')) {
            homeViewerIndex.setHelpContentHeight();
        }

        if ((typeof helpEditor != 'undefined') && (typeof helpEditor.setHelpContentHeight != 'undefined')) {
            helpEditor.setHelpContentHeight();
            helpEditor.setHelpContentChildrenHeight();
            helpEditor.setHelpTreeHeight();
        }

        if ((typeof helpDashboard != 'undefined') && (typeof helpDashboard.setHelpContentHeight != 'undefined')) {
            helpDashboard.setHelpContentHeight();
        }

    };

    this.confirmSendEmail = function () {

        if (parseInt($("#hdnSiteId").val()) < 0) {
            wikihelpCommon.showConfirmBox(jsResources.SendEmail_PopUp_Title, jsResources.SendEmail_PopUp_InformationMessageForGlobalSite, wikihelpCommon.sendEmail);
        }
        else {
            wikihelpCommon.showConfirmBox(jsResources.SendEmail_PopUp_Title, jsResources.SendEmail_PopUp_InformationMessage, wikihelpCommon.sendEmail);
        }

    }

    this.CloseConfirmBox = function () {
        if (Browser.Version() < 9) {
            $("div.overlay").hide();
        }
        else {
            $("div.overlay").fadeOut([5000], [20]);
        }
        $("#wikihelpConfirmBox").hide();
        return false;
    }

    this.showConfirmBox = function (confirmHeader, confirmMessage, confirmOKClick) {
        if (Browser.Version() < 9) {
            $("div.overlay").show();
        }
        else {
            $("div.overlay").fadeIn([50000], [90]);
        }
        $("#headingConfirmBox").html(confirmHeader);
        $("#wikihelpConfirmBox").show();
        $("#lblConfirmBoxInfoMessage").text(confirmMessage);
        $("#wikihelpConfirmOKButton").unbind('click');
        $("#wikihelpConfirmOKButton").click(confirmOKClick);
        return false;
    }

    this.sendEmail = function () {
        var actionUrl = '';
        if (typeof homeViewerIndex != 'undefined') {
            actionUrl = '/Help/TestEmailScheduler';
        }

        if (typeof helpEditor != 'undefined') {
            actionUrl = '/HelpEditor/TestEmailScheduler';
        }
        wikihelpCommon.CloseConfirmBox();
        $.post(actionUrl);
    }

    this.printAllHelps = function () {
        wikihelpCommon.CloseConfirmBox();
        var actionUrl = $('#divPrintAllHelp').attr('href');
        window.open(actionUrl, "_blank");
    }

    this.scrolify = function (tblAsJQueryObject, height) {
        var oTbl = tblAsJQueryObject;

        // for very large tables you can remove the four lines below
        // and wrap the table with <div> in the mark-up and assign
        // height and overflow property  
        var oTblDiv = $("<div/>");
        oTblDiv.css('height', height);
        oTblDiv.css('overflow-y', 'scroll');
        oTblDiv.css('overflow-x', 'hidden');
        oTbl.wrap(oTblDiv);

        // save original width
        oTbl.attr("data-item-original-width", oTbl.width());
        oTbl.find('thead tr td').each(function () {
            $(this).attr("data-item-original-width", $(this).width());
        });
        oTbl.find('tbody tr:eq(0) td').each(function () {
            $(this).attr("data-item-original-width", $(this).width());
        });


        // clone the original table
        var newTbl = oTbl.clone();

        // remove table header from original table
        oTbl.find('thead tr').remove();
        // remove table body from new table
        newTbl.find('tbody tr').remove();

        oTbl.parent().parent().prepend(newTbl);
        newTbl.wrap("<div/>");

        // replace ORIGINAL COLUMN width                
        newTbl.width(newTbl.attr('data-item-original-width'));
        newTbl.find('thead tr td').each(function () {
            $(this).width($(this).attr("data-item-original-width"));
        });
        oTbl.width(oTbl.attr('data-item-original-width'));
        oTbl.find('tbody tr:eq(0) td').each(function () {
            $(this).width($(this).attr("data-item-original-width"));
        });
    }

}

var Browser = {
    Version: function () {
        var version = 999; // we assume a sane browser
        if (navigator.appVersion.indexOf("MSIE") != -1)
            // bah, IE again, lets downgrade version number
            version = parseFloat(navigator.appVersion.split("MSIE")[1]);
        return version;
    }
}



