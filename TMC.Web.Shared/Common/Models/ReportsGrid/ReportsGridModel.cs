using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using TMC.Web.Shared;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Model for reports grid
    /// </summary>
    public class ReportsGridModel
    {
        /// <summary>
        /// Unique id for grid
        /// </summary>
        public string GridViewUniqueId { get; set; }

        /// <summary>
        /// Callback for grid
        /// </summary>
        public string GridLoadCallback { get; set; }

        /// <summary>
        /// Url to load grid
        /// </summary>
        public string SortGridCallback { get; set; }

        /// <summary>
        /// Grid Columns
        /// </summary>
        public IList<ReportsGridColumnModel> Columns { get; set; }

        /// <summary>
        /// Grid Rows
        /// </summary>
        public IList<ReportsGridRowModel> Rows { get; set; }

        /// <summary>
        /// Css class for the grid
        /// </summary>
        public string CssClass { get; set; }
    }

    /// <summary>
    /// Model for Reports grid column
    /// </summary>
    public class ReportsGridColumnModel 
    {
        /// <summary>
        /// Name of column
        /// </summary>
        public string HeaderName { get; set;}

        /// <summary>
        /// Name used for sorting data table
        /// </summary>
        public string DataColumnName { get; set; }

        /// <summary>
        /// Is column sortable
        /// </summary>
        public bool IsSortable { get; set; }

        /// <summary>
        /// Is column sorted
        /// </summary>
        public bool IsSorted { get; set;}

        /// <summary>
        /// Is column sorted in ascending order
        /// </summary>
        public bool IsSortedAscending { get; set;}

        /// <summary>
        /// Css class for the column
        /// </summary>
        public string CssClass { get; set; }
    }

    /// <summary>
    /// Model for Reports grid row
    /// </summary>
    public class ReportsGridRowModel
    {
        /// <summary>
        /// Cells of a grid
        /// </summary>
        public IDictionary<ReportsGridColumnModel, ReportsGridCellModel> Cells { get; set; }

        /// <summary>
        /// Css class for a row
        /// </summary>
        public string CssClass { get; set; }
    }

    /// <summary>
    /// Model for reports grid cell
    /// </summary>
    public class ReportsGridCellModel
    {
        /// <summary>
        /// Value of a cell
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Is the cell going to contain html value or plain text
        /// </summary>
        public bool IsHTML { get; set; }

        /// <summary>
        /// Row span of a cell
        /// </summary>
        public int? RowSpan { get; set; }

        /// <summary>
        /// column span of a cell
        /// </summary>
        public int? ColumnSpan { get; set; }

        /// <summary>
        /// Css Class for a cell
        /// </summary>
        public string CssClass { get; set; }
    }
}