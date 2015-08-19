using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMC.Web.Shared
{
    using System.ComponentModel.DataAnnotations;

    public class DualListModel
    {
        public DualListModel()
        {
            AllowAddRemove = true;
            AllowAddRemoveAll = true;
            AllowDragging = true;
            AllowArrange = false;
            AllowLeftListSearch = true;
            AllowRightListSearch = true;
            RequiredMessage = "Required";
        }

        public string ContainerId { get; set; }
        public string LeftListId { get; set; }
        public string RightListId { get; set; }

        public string AddButtonId
        {
            get { return "btnAdd_" + this.ContainerId; }
        }

        public string RemoveButtonId
        {
            get { return "btnRemove_" + this.ContainerId; }
        }

        public string AddAllButtonId
        {
            get { return "btnAddAll_" + this.ContainerId; }
        }

        public string RemoveAllButtonId
        {
            get { return "btnRemoveAll_" + this.ContainerId; }
        }

        public string UpButtonId
        {
            get { return "btnUp_" + this.ContainerId; }
        }

        public string DownButtonId
        {
            get { return "btnDown_" + this.ContainerId; }
        }

        public string LeftListSearchBoxId
        {
            get { return "txtLeftListSearchBox_" + this.ContainerId; }
        }

        public string RightListSearchBoxId
        {
            get { return "txtRightListSearchBox_" + this.ContainerId; }
        }

        public string AddButtonJSCallback { get; set; }
        public string RemoveButtonJSCallback { get; set; }
        public string AddAllButtonJSCallback { get; set; }
        public string RemoveAllButtonJSCallback { get; set; }
        public string UpButtonJSCallback { get; set; }
        public string DownButtonJSCallback { get; set; }
        public string LeftListSearchBoxJSCallback { get; set; }
        public string RightListSearchBoxJSCallback { get; set; }
        public string ItemDraggedJSCallback { get; set; }

        public string LeftListHeader { get; set; }
        public string RightListHeader { get; set; }
        public string ListMainHeader { get; set; }
        public IEnumerable<IDualListItem> LeftList { get; set; }
        public IEnumerable<IDualListItem> RightList { get; set; }

        public int NumberOfDisplayItems { get; set; }
        public string WidthCSSClassName { get; set; }

        public bool AllowAddRemove { get; set; }
        public bool AllowAddRemoveAll { get; set; }
        public bool AllowDragging { get; set; }
        public bool AllowArrange { get; set; }
        public bool AllowLeftListSearch { get; set; }
        public bool AllowRightListSearch { get; set; }

        ///<summary>
        /// Gets or sets a value indicating whether is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the required message.
        /// </summary>
        public string RequiredMessage { get; set; }

        [RequiredIf("IsRequired", true)]
        public string SelectedDualListData { get; set; }

        public string ListHtmlFieldPrefix { get; set; }

        private List<int> _listSelectedData;

        public List<int> ListSelectedData
        {
            get
            {
                _listSelectedData = new List<int>();
                if (!string.IsNullOrWhiteSpace(SelectedDualListData))
                {
                    _listSelectedData = new List<int>(SelectedDualListData.Split(',').Select(int.Parse));
                }

                return _listSelectedData;
            }
        }

        public string DefaultRightListSelectedValues
        {
            get;
            set;
        }
    }
}