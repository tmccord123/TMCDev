using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TMC.Web.Shared
{
    [DataContract]
    public class GridViewState
    {
        [DataMember]
        public string CurrentSortExpression { get; set; }

        [DataMember]
        public string CurrentSortDirection { get; set; }

        [DataMember]
        public string RequestedSortExpression { get; set; }

        [DataMember]
        public string RequestedSortDirection { get; set; }

        [DataMember]
        public int CurrentPageIndex { get; set; }

        [DataMember]
        public int RequestedPageIndex { get; set; }

        [DataMember]
        public IList<GridViewFilter> GridFilters { get; set; }
    }
}