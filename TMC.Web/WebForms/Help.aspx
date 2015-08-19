<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="WikiHelp.WebApp.WebForms.Help" %>

<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../images/css/Style.css" rel="stylesheet" type="text/css" />
    <style>
        /*.CuteEditorTextArea  { font-family: Arial ; font-size: 9px; font-weight: normal; text-decoration: none; }*/
        div .fltL a, table .btnTile a {
            text-decoration: none;
            color: Black;
        }

            div .fltL a:hover {
                text-decoration: none;
                color: Black;
                font-weight: bold;
            }

        table a:active {
            text-decoration: none;
            color: Black;
            font-weight: bold;
        }

        .selectedlink {
            text-decoration: none;
            color: Black;
            font-weight: bold;
        }
    </style>
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=9" />
</head>
<body style="height: 100%">
      <form id="form1" runat="server" style="height: 100%">
        <div style="width: 100%; height: 100%">

            <table width="100%" style="height: 100%" border="0" cellspacing="0" cellpadding="0">
              
                <tr>
                    <td valign="top" align="center" width="100%" class="contentsection" style="height: 100%">
                        <div class="editorContainer" style="height: 100%; width: 100%">
                            <div class="editorArea" id="texteditorArea" style="height: 100%; width: 100%">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0" style="height: 100%">
                                    <tr>
                                        <td style="width: 100%; height: 100%" id="tdContent">
                                            <div style="overflow: auto;">
                                                <CE:Editor EnableStripScriptTags="false" TabIndex="1" ID="ftbFieldValue" AutoConfigure="Compact"
                                                    runat="server" Height="99%" Width="98%" ResizeMode="None">
                                                </CE:Editor>
                                                 
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <!-- editor Area-->
                            <div class="CLRBoth">
                            </div>
                        </div>

                    </td>
                </tr>
            </table>
        </div>

        <input type="hidden" id="hidIsEditorSelected" runat="server" value="false" />
    </form>
    <script type="text/javascript">
        var isDirty = false;


    </script>
</body>
</html>
