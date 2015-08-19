using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents the class for Shared Custom Gridview control
    /// </summary>
    public class GridViewAction
    {
        #region public properties        

        /// <summary>
        /// To Get or Set Column Css ClassName
        /// </summary>
        public string CssClassName { get; set; }

        /// <summary>
        /// To Get or Set Javascript Call back method
        /// </summary>
        public string JSCallbackMethod { get; set; }

        /// <summary>
        /// To Get or Set Tooltip
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// To Get or Set Disabled property
        /// </summary>
        public bool Disabled { get; set; }

        public Dictionary<string, string> CssClassMapping { get; set; }

        public string BindColumnName { get; set; }

        public bool IsHighlightRow { get; set; }

        public string HighlightRowCSS { get; set; }

        #endregion
    }
}