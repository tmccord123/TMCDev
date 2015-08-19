using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Web.Shared
{
    public static class GridViewConstants
    {
        public const string HighlightTextDelimiter = "##highlightText##";

        public const string Ascending = "ASC";
        public const string Descending = "DESC";
        public const string FilterPlaceholder = "##filterValue##";
        public const string GridRowCSSColumn = "GridRowCSSColumn";
        public const int DefaultGridPageSize = 5;
        public const int DefaultGridMaxVisiblePages = 10;
        public const int StartRowIndex = 1;

        public const string GroupedColumnName = "[##columnName##]";
    }
}