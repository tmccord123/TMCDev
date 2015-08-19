#region Namespace

using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Resources;
using System.Web;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TMC.Shared;

#endregion

namespace TMC.Web.Shared
{
    /// <summary>
    /// Provides static utility methods for Grid View
    /// Author : Nagarro
    /// </summary>
    public static class GridViewUtility
    {
        #region "Constants"

        public const string AndString = " and";

        #endregion

        /// <summary>
        /// Returns the grid view pager
        /// </summary>
        /// <param name="gridViewState"></param>
        /// <returns></returns>
        public static GridViewPager GetGridViewPager(GridViewState gridViewState)
        {
            GridViewPager gridViewPager = new GridViewPager();

            if (gridViewState.RequestedPageIndex > 0)
            {
                gridViewPager.CurrentPageIndex = gridViewState.RequestedPageIndex;
            }
            else if (gridViewState.RequestedPageIndex == 0 && gridViewState.CurrentPageIndex != 0)
            {
                gridViewPager.CurrentPageIndex = gridViewState.CurrentPageIndex;
            }
            else
            {
                gridViewPager.CurrentPageIndex = 1;
            }

            gridViewPager.PageSize =
                AppConstantsUtility.ReadDefaultValueIfEmpty<int>(AppConstants.ConfigurationKeys.GridPageSize,
                                                                 GridViewConstants.DefaultGridPageSize);
            gridViewPager.MaximumNumberOfVisiblePages =
                AppConstantsUtility.ReadDefaultValueIfEmpty<int>(
                    AppConstants.ConfigurationKeys.GridMaximumNumberOfVisiblePages,
                    GridViewConstants.DefaultGridMaxVisiblePages);

            return gridViewPager;
        }

        /// <summary>
        /// Returns the grid view pager start index
        /// </summary>
        /// <param name="gridViewPager"></param>
        /// <returns></returns>
        public static int GetStartRowIndex(GridViewPager gridViewPager)
        {
            return (gridViewPager.PageSize * (gridViewPager.CurrentPageIndex - 1)) + 1;
        }

        /// <summary>
        /// Returns the grid view pager end index
        /// </summary>
        /// <param name="gridViewPager"></param>
        /// <returns></returns>
        public static int GetEndRowIndex(GridViewPager gridViewPager)
        {
            return gridViewPager.PageSize * gridViewPager.CurrentPageIndex;
        }

        /// <summary>
        /// Returns the current sort direction from grid view state
        /// </summary>
        /// <param name="gridViewState"></param>
        /// <param name="currentSortDirection"></param>
        /// <returns></returns>
        public static string GetCurrentSortDirection(GridViewState gridViewState, string currentSortDirection)
        {
            string sortDirection = currentSortDirection;

            if (!string.IsNullOrEmpty(gridViewState.RequestedSortDirection))
            {
                sortDirection = gridViewState.RequestedSortDirection;
            }
            else if (!string.IsNullOrEmpty(gridViewState.CurrentSortDirection))
            {
                sortDirection = gridViewState.CurrentSortDirection;
            }

            return sortDirection;
        }

        /// <summary>
        /// Returns the current sort expression from grid view state
        /// </summary>
        /// <param name="gridViewState"></param>
        /// <param name="currentSortExpression"></param>
        /// <returns></returns>
        public static string GetCurrentSortExpression(GridViewState gridViewState, string currentSortExpression)
        {
            string sortExpression = currentSortExpression;

            if (!string.IsNullOrEmpty(gridViewState.RequestedSortExpression))
            {
                sortExpression = gridViewState.RequestedSortExpression;
            }
            else if (!string.IsNullOrEmpty(gridViewState.CurrentSortExpression))
            {
                sortExpression = gridViewState.CurrentSortExpression;
            }

            return sortExpression;
        }

        /// <summary>
        /// Get current filter expression from grid view model
        /// </summary>
        /// <param name="gridViewModel"></param>
        /// <returns></returns>
        public static string GetCurrentFilterExpression(GridViewModel gridViewModel)
        {
            StringBuilder retVal = new StringBuilder();

            if (gridViewModel.GridFilters != null)
            {
                foreach (GridViewFilter gridFilter in gridViewModel.GridFilters)
                {
                    GridViewColumn gridColumn = gridViewModel.GridViewColumns.FirstOrDefault(x => x.ColumnName == gridFilter.ColumnName);

                    retVal.Append(" ");

                    if (gridColumn != null && !string.IsNullOrEmpty(gridColumn.SortExpression))
                    {
                        retVal.Append(gridColumn.SortExpression);
                    }
                    else
                    {
                        retVal.Append(gridFilter.ColumnName);
                    }

                    retVal.Append(
                        gridViewModel.GetFilterExpression((GridFilterOperatorType)gridFilter.QueryOperator));
                    retVal.Replace(GridViewConstants.FilterPlaceholder,
                                       gridFilter.FilterValue.Replace("'", "''"));
                    retVal.Append(GridViewUtility.AndString);
                }
            }

            if (retVal.Length > 0)
            {
                retVal.Length -= GridViewUtility.AndString.Length;
            }

            return retVal.ToString();
        }

    }
}