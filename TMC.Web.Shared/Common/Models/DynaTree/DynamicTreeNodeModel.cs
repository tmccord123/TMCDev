using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents the class for Shared Custom Tree control
    /// </summary>
    public class DynamicTreeNodeModel
    {
        #region "Ctor"

        public DynamicTreeNodeModel()
        {
            title = null;
            key = null;
            isFolder = false;
            isLazy = false;
            tooltip = null;
            href = null;
            icon = null;
            addClass = null;
            noLink = false;
            activate = false;
            focus = false;
            expand = false;
            select = false;
            hideCheckbox = false;
            unselectable = false;
            children = null;
            canEditNode = false;
            canDeleteNode = false;
        }

        #endregion

        #region public properties

        public string title { get; set; } // (required) Displayed name of the node (html is allowed here)
        public string key { get; set; }
        //will create id of li element in html. May be used with activate(), select(), find(), ...
        public bool isFolder { get; set; } // Use a folder icon. Also the node is expandable but not selectable.
        public bool isLazy { get; set; }
        // Call onLazyRead(), when the node is expanded for the first time to allow for delayed creation of children.
        public string tooltip { get; set; } // Show this popup text.
        public string href { get; set; } // Added to the generated <a> tag.
        public string icon { get; set; }
        // Use a custom image (filename relative to tree.options.imagePath). 'null' for default icon, 'false' for no icon.
        public string addClass { get; set; } // Class name added to the node's span tag.
        public bool noLink { get; set; } // Use <span> instead of <a> tag for this node
        public bool activate { get; set; } // Initial active status.
        public bool focus { get; set; } // Initial focused status.
        public bool expand { get; set; } // Initial expanded status.
        public bool select { get; set; } // Initial selected status.
        public bool hideCheckbox { get; set; }

        // Suppress checkbox display for this node.
        public bool unselectable { get; set; } // Prevent selection.
        // The following attributes are only valid if passed to some functions:
        public IList<DynamicTreeNodeModel> children { get; set; } // Array of child nodes.
        public bool canEditNode { get; set; }
        public bool canDeleteNode { get; set; }

        #endregion
    }
}