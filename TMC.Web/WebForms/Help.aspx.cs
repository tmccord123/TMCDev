using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TMC.Shared;
//using WebSupergoo.ABCpdf6;
using System.IO;
using System.Text;
using System.Configuration;


namespace WikiHelp.WebApp.WebForms
{
    public partial class Help : System.Web.UI.Page
    {

        private int productID = 1;
        private int siteID = 30;
        private int languageID = 1;


        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.ftbFieldValue.EditorWysiwygModeCss = "../css/EditorStyle.css";
            }
        }

        #region Control Events
 
        //}

        #endregion

    }
}