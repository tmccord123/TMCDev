
namespace TMC.Web.Shared.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The ServiceArea  view model.
    /// </summary>
    public class ServiceLocationViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string CityName { get; set; }
          

        public long ListingId { get; set; }
        public long ListingServiceLocationId { get; set; }
    }
}