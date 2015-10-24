
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface IListingServiceAreasDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        IList<IServiceAreaDTO> ServiceAreas { get; set; }

         
    }
}
