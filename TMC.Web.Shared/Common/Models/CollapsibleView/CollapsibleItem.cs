using System.Collections.Generic;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Class which contains the information of the Collapsible Item
    /// </summary>
    public class CollapsibleItem
    {
        #region "Ctor"

        /// <summary>
        /// Initializes a new instance of the <see cref="CollapsibleItem"/> class.
        /// </summary>
        public CollapsibleItem()
        {
        }

        #endregion "Ctor"

        /// <summary>
        /// Gets or sets the collapsible item title.
        /// </summary>
        /// <value>The collapsible item title.</value>
        public string CollapsibleItemTitle { get; set; }

        /// <summary>
        /// The additional details
        /// </summary>
        public IList<KeyValuePair<string, string>> AdditionalDetails;

        public object ChildModel { get; set; }
    }
}