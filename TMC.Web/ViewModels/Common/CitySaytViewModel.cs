
namespace TMC.Web.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The city SAYT view model.
    /// </summary>
    public class CitySaytViewModel
    {

        public CitySaytViewModel()
        {
            RequiredMessage = "Required";
            PlaceHolder = "e.g. Delhi, Gurgaon";            

        }

        private string SelectedCityNameIdSuffix = "SelectedCityName";

        private string SelectedCityIdSuffix = "SelectedCityId";

        private string SelectedCityDetailsSuffix = "SelectedCityDetails";
        public string AjaxGetUrl { get; set; }
        

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
        public string SelectedCityId { get; set; }

        public string SelectedCityName { get; set; }

        public string SelectedCityDetails { get; set; }

        public string DefaultSelectedValue { get; set; }

        public string PlaceHolder { get; set; }

        public string HtmlFieldPrefix { get; set; }

        public string SelectCallBack { get; set; }


        public string SelectedCityNameFieldId 
        {
            get 
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedCityNameIdSuffix;
                }
                else {
                    return SelectedCityNameIdSuffix;
                }
                 
            }
        }

        public string SelectedCityIdFieldId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedCityIdSuffix;
                }
                else
                {
                    return SelectedCityIdSuffix;
                }

            }
        }

        public string SelectedCityDetailsFieldId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedCityDetailsSuffix;
                }
                else
                {
                    return SelectedCityDetailsSuffix;
                }

            }
        }
    }
}