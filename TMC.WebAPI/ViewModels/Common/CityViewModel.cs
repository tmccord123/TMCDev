
namespace TMC.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The city view model.
    /// </summary>
    public class CityViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the state id.
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public string Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public string Long { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is popular.
        /// </summary>
        public bool IsPopular { get; set; }

        /// <summary>
        /// Gets or sets the population class.
        /// </summary>
        public short PopulationClass { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Gets or sets the CombinedCityDetails.
        /// </summary>
        public int CombinedCityDetails { get; set; }

    }
}