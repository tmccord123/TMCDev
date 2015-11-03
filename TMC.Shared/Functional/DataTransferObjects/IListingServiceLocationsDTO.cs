
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface IListingServiceLocationsDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        IList<IServiceLocationDTO> ServiceLocations { get; set; }

         
    }
}
