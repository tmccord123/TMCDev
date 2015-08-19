using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMC.Web.Shared;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents the class for Shared Custom Gridview control
    /// </summary>
    public class GridViewColumn
    {
        public GridViewColumn()
        {
            ColumnType = GridColumnType.Label;
        }

        #region public properties

        /// <summary>
        /// To Get or Set ColumnName for GridView
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// To Get or Set Column DisplayName for GridView
        /// </summary>
        public string ColumnDisplayName { get; set; }

        /// <summary>
        /// To Get or Set Column sort expression for GridView
        /// </summary>
        public string SortExpression { get; set; }

        /// <summary>
        /// To Get or Set Column  Css Style
        /// </summary>
        public string CssStyle { get; set; }

        /// <summary>
        /// To Get or Set Column Css ClassName
        /// </summary>
        public string CssClassName { get; set; }

        /// <summary>
        /// To Get or Set Column Visibility
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// To Get or Set Column disabled or not
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// To Get or Set Column type
        /// </summary>
        public GridColumnType ColumnType { get; set; }

        /// <summary>
        /// To Get or Set Javascript Call back method
        /// </summary>
        public string JSCallbackMethod { get; set; }

        /// <summary>
        /// To Get or Set Column Filtering
        /// </summary>
        public bool AllowFiltering { get; set; }

        /// <summary>
        /// To Group the data
        /// </summary>
        public bool IsGrouped { get; set; }

        /// <summary>
        /// Gets or sets the row class mapping.
        /// </summary>
        /// <value>The row class mapping.</value>
        public IDictionary<string, string> RowClassMapping { get; set; }

        #endregion
    }
}