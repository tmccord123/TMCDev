using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for ListingContacts DTO.
    /// </summary>
    public class ListingContactsDTO : DTOBase, IListingContactsDTO
    {
        public IList<IListingContactDTO> Contacts { get; set; }
         
    }
}
