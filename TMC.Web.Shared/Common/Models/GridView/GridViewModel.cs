using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using TMC.Web.Shared;

namespace TMC.Web.Shared
{
    /// <summary>
    /// To Specify Properties of Gridview User Control
    /// </summary>
    public class GridViewModel
    {
        private const string EmptyResultConst = "No row found.";
        private const string ContainsConst = "Contains";
        private const string IsEqualsConst = "Is Equals";
        private const string IsBeforeConst = "Is before";
        private const string IsAfterConst = "Is after";

        #region "Ctor"

        public GridViewModel()
        {
            this.GridViewColumns = new List<GridViewColumn>();
            this.GridViewActions = new List<GridViewAction>();
            this.GridFilters = new List<GridViewFilter>();
            this.JSONGridColumns = this.GetJSONColumn();
            this.Pager = new GridViewPager();
            this.IsPagingAllowed = true;
            this.ShowColumnHeaders = true;
            this.EmptyResultText = EmptyResultConst;
        }

        #endregion

        #region public properties

        /// <summary>
        /// To Get or Set Unique Id for GridView control
        /// </summary>
        public string GridViewUniqueId { get; set; }

        /// <summary>
        /// To Get or Set Gridview Columns information
        /// </summary>
        public IList<GridViewColumn> GridViewColumns { get; set; }

        /// <summary>
        /// To Get or Set Data Source
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// To Get or Set Pager information
        /// </summary>
        public GridViewPager Pager { get; set; }

        /// <summary>
        /// To Get or Set Controller Action for binding or getting data for Gridview control
        /// </summary>
        public string ControllerAction { get; set; }

        /// <summary>
        /// To Get or Set Paging allowed or not
        /// </summary>
        public bool IsPagingAllowed { get; set; }

        /// <summary>
        /// To Get or Set Current SortExpression
        /// </summary>
        public string CurrentSortExpression { get; set; }

        /// <summary>
        /// To Get or Set Current SortDirection
        /// </summary>
        public string CurrentSortDirection { get; set; }

        /// <summary>
        /// To Get or Set Gridview Actions information
        /// </summary>
        public IList<GridViewAction> GridViewActions { get; set; }

        public bool AllowRowSelection { get; set; }
        public bool AllowMultiRowSelection { get; set; }
        public string JSRowSelectionChangeCallbackFunction { get; set; }

        public string PrimaryKeyColumnName { get; set; }

        public IList<GridViewFilter> GridFilters { get; set; }

        public string JSONGridColumns { get; set; }

        public bool AllowDragAndDrop { get; set; }

        public string JSDragAndDropCompletedCallbackFunction { get; set; }

        public bool ShowColumnHeaders { get; set; }

        public string CssActionsColumn { get; set; }

        public string EmptyResultText { get; set; }

        public string GridLoadCompleteCallback { get; set; }

        public bool DisplayBorder { get; set; }

        public bool DisableAlternateRowColor { get; set; }

        public bool DisplayGroupedColumnName { get; set; }

        #endregion

        /// <summary>
        /// This Method returns the filter expression based on selected filter operator
        /// </summary>
        /// <param name="filterOperator"></param>
        /// <returns></returns>
        public string GetFilterExpression(GridFilterOperatorType filterOperator)
        {
            string filterText = string.Empty;
            switch (filterOperator)
            {
                case GridFilterOperatorType.Contains:
                    filterText = " like '%" + GridViewConstants.FilterPlaceholder + "%'";
                    break;
                case GridFilterOperatorType.Isequalto:
                    filterText = " = '" + GridViewConstants.FilterPlaceholder + "'";
                    break;
                case GridFilterOperatorType.Isbefore:
                    filterText = " < '" + GridViewConstants.FilterPlaceholder + "'";
                    break;
                case GridFilterOperatorType.Isafter:
                    filterText = " > '" + GridViewConstants.FilterPlaceholder + "'";
                    break;
            }
            return filterText;
        }

        private string GetJSONColumn()
        {
            StringBuilder jsonColumns = new StringBuilder();
            jsonColumns.Append(@"{""label"": { ""value"": ");
            jsonColumns.Append((int)GridColumnType.Label);
            jsonColumns.Append(@", ""filters"": [{ ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Contains);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(ContainsConst);
            jsonColumns.Append(@""" }, { ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Isequalto);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(IsEqualsConst);
            jsonColumns.Append(@"""}] },""checkbox"": { ""value"": ");
            jsonColumns.Append((int)GridColumnType.CheckBox);
            jsonColumns.Append(@"},""icon"": { ""value"": ");
            jsonColumns.Append((int)GridColumnType.Icon);
            jsonColumns.Append(@"},""datetime"": { ""value"": ");
            jsonColumns.Append((int)GridColumnType.DateTime);
            jsonColumns.Append(@", ""filters"": [{ ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Isbefore);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(IsBeforeConst);
            jsonColumns.Append(@""" }, { ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Isafter);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(IsAfterConst);
            jsonColumns.Append(@"""}] },""date"": { ""value"": ");
            jsonColumns.Append((int)GridColumnType.Date);
            jsonColumns.Append(@", ""filters"": [{ ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Isbefore);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(IsBeforeConst);
            jsonColumns.Append(@""" }, { ""key"": ");
            jsonColumns.Append((int)GridFilterOperatorType.Isafter);
            jsonColumns.Append(@", ""value"": """);
            jsonColumns.Append(IsAfterConst);
            jsonColumns.Append(@"""}] }}");

            return jsonColumns.ToString();
        }
    }
}