
namespace TMC.Web.Shared.ViewModels
{
    using System.Collections.Generic;

    using TMC.Web.Shared;

    /// <summary>
    /// The home view model.
    /// </summary>
    public class HomeViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        public List<CityViewModel> Cities { get; set; }

        public CitySaytViewModel CitySaytHome { get; set; }

        public PlaceSaytViewModel PlaceSaytHome { get; set; }

        public CategorySaytViewModel CategorySaytHome { get; set; }

        /// <summary>
        /// Gets or sets the Top Categories.
        /// </summary>
        public List<CategoryViewModel> TopCategories { get; set; }

    }
}