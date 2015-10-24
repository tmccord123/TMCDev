﻿
namespace TMC.Web.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The ServiceArea  view model.
    /// </summary>
    public class PaymentModeViewModel : ViewModelBase
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
    }
}