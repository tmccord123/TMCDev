using System.Collections.Generic;

namespace TMC.Web.Shared
{
    public interface IDualListItemGroup
    {
        string GroupName { get; set; }
        IEnumerable<IDualListItem> Items { get; set; }
    }
}