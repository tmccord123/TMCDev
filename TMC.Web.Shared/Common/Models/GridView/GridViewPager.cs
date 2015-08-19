using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Web.Shared
{
    public class GridViewPager
    {
        #region public properties

        /// <summary>
        /// To Get or Set Current Page Index
        /// </summary>
        public int CurrentPageIndex { get; set; }

        /// <summary>
        /// To Get or Set Page size of gridview
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// To Get or Set Total Recoud Count
        /// </summary>
        public int TotalRecordCount { get; set; }

        /// <summary>
        /// To Get or set maximum number of visible pages
        /// </summary>
        public int MaximumNumberOfVisiblePages { get; set; }

        /// <summary>
        /// To get page count
        /// </summary>
        public int PageCount
        {
            get
            {
                int pageCount = 0;
                if (
                    (Decimal.Parse(this.TotalRecordCount.ToString())/
                     (Decimal.Parse(this.PageSize.ToString()) == 0 ? 1 : Decimal.Parse(this.PageSize.ToString()))) >
                    (this.TotalRecordCount/(this.PageSize == 0 ? 1 : this.PageSize)))
                {
                    pageCount = (this.TotalRecordCount/(this.PageSize == 0 ? 1 : this.PageSize)) + 1;
                }
                else
                {
                    pageCount = (this.TotalRecordCount/(this.PageSize == 0 ? 1 : this.PageSize));
                }
                return pageCount;
            }
        }

        #endregion
    }
}