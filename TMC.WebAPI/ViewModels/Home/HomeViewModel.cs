
namespace TMC.Web.ViewModels
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

        /// <summary>
        /// Gets or sets the Top Categories.
        /// </summary>
        public List<CategoryViewModel> TopCategories { get; set; }

    }
}