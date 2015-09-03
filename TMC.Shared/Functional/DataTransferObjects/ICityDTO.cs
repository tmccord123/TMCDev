
namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface ICityDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        int CityId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the state id.
        /// </summary>
        int StateId { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        string Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        string Long { get; set; }

        /// <summary>
        /// Gets or sets the pin code.
        /// </summary>
        //int PinCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is popular.
        /// </summary>
        bool IsPopular { get; set; }

        /// <summary>
        /// Gets or sets the population class.
        /// </summary>
        int PopulationClass { get; set; }
    }
}
