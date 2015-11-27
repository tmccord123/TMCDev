
namespace TMC.Web.Shared.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The place SAYT view model.
    /// </summary>
    public class CategorySaytViewModel
    {

        public CategorySaytViewModel()
        {
            RequiredMessage = "Required";
            PlaceHolder = "e.g. Tutions, Hotels";

        }

        private string SelectedCategoryIdSuffix = "SelectedCategoryId";

        private string SelectedCategoryNameSuffix = "SelectedCategoryName";

        /// <summary>
        /// Gets or sets the control id.
        /// </summary>
        public string ControlId { get; set; }

        ///<summary>
        /// Gets or sets a value indicating whether is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the required message.
        /// </summary>
        public string RequiredMessage { get; set; }

        [RequiredIf("IsRequired", true)]
        public string SelectedCategoryId { get; set; }

        public string SelectedCategoryName { get; set; }

        public string DefaultSelectedValue { get; set; }

        public string PlaceHolder { get; set; }

        public string HtmlFieldPrefix { get; set; }

        public string SelectCallBack { get; set; }       

        public string SelectedCategoryIdFieldId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedCategoryIdSuffix;
                }
                else
                {
                    return SelectedCategoryIdSuffix;
                }

            }
        }

        public string SelectedCategoryNameFieldId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedCategoryNameSuffix;
                }
                else
                {
                    return SelectedCategoryNameSuffix;
                }

            }
        }

    }
}