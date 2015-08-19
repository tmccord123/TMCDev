using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TMC.Web.Shared
{

    #region "Data Contract for Custom Data for contacts"

    [DataContract]
    public class ContactsCustomData
    {
        [DataMember]
        public int OrganizationLocationId { get; set; }

        [DataMember]
        public int MasterDataColumnId { get; set; }

        [DataMember]
        public string AllowMultipleRecord { get; set; }

        [DataMember]
        public string SelectedColumnDisplay { get; set; }
    }

    public class ContactsData
    {
        public string PrimaryKeyColumn { get; set; }

        public string SelectedColumnDisplay { get; set; }

        public IList<SelectedContactsData> SelectedContacts { get; set; }
    }

    [DataContract]
    public class SelectedContactsData
    {
        [DataMember]
        public int MasterRecordId { get; set; }

        [DataMember]
        public string TextData { get; set; }
    }

    #endregion
}