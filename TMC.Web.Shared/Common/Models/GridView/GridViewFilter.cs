using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents the class for Shared Custom Gridview control
    /// </summary>
    public class GridViewFilter
    {
        #region public properties

        public string ColumnName { get; set; }

        public int QueryOperator { get; set; }

        public string FilterValue { get; set; }

        #endregion
    }
}