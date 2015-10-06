
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface IListingContactsDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        IList<IListingContactDTO> Contacts { get; set; }

         
    }
}
