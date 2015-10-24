
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface IListingMediasDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        IList<IMediaDTO> Medias { get; set; }

         
    }
}
