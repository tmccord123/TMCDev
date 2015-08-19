using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents the class for dynamic tree search
    /// </summary>
    public class DynamicTreeSearchModel
    {
        #region Public properties

        public string DynamicTreeDivId { get; set; }

        public string SearchText { get; set; }

        public bool SearchNodeText { get; set; }

        public bool HighlightResult { get; set; }

        public bool ExpandItemsOnReset { get; set; }

        #endregion
    }
}