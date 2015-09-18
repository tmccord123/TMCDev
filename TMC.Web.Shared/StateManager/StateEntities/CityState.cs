using System.Collections.Generic;

namespace TMC.Web.Shared
{
    using TMC.Shared;

    /// <summary>
    /// Represents city information.
    /// </summary>
    public class CityState : StateEntityBase
    {
        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        public IList<ICityDTO> Cities { get; set; }
    }
}