
namespace TMC.Web.ViewModels
{
    using System.Collections.Generic;

    using TMC.Web.Shared;

    /// <summary>
    /// The local board view model.
    /// </summary>
    public class LocalBoardViewModel : ViewModelBase
    {
        /// <summary>
        /// The city place holder.
        /// </summary>
        public string CityPlaceHolder = "##CityPlaceHolder##";

        /// <summary>
        /// The place holder.
        /// </summary>
        public string PlacePlaceHolder = "##PlacePlaceHolder##";

        /// <summary>
        /// The category place holder.
        /// </summary>
        public string CategoryPlaceHolder = "##CategoryPlaceHolder##";

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the heading.
        /// </summary>
        public string SearchResultHeading { get; set; }

        /// <summary>
        /// Gets or sets the trend heading.
        /// </summary>
        public string TrendHeading { get; set; }

        public string ListingLogo { get; set; }

        /// <summary>
        /// Gets or sets the Listings.
        /// </summary>
        public List<ListingViewModel> Listings { get; set; }

    }
}