
namespace TMC.Web.Shared.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The Category view model.
    /// </summary>
    public class CategoryViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        public int? Popularity { get; set; }


        public long ListingId { get; set; }
        public long ListingCategoryId { get; set; }
    }
}