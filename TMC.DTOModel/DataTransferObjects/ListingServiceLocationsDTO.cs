using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for ListingServiceLocations DTO.
    /// </summary>
    public class ListingServiceLocationsDTO : DTOBase, IListingServiceLocationsDTO
    {
        public IList<IServiceLocationDTO> ServiceLocations { get; set; }
         
    }
}
