
namespace TMC.Web.Shared.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The place SAYT view model.
    /// </summary>
    public class PlaceSaytViewModel
    {

        public PlaceSaytViewModel()
        {
            RequiredMessage = "Required";
            PlaceHolder = "e.g. Palam Vihar";

        }

        private string SelectedPlaceIdSuffix = "SelectedPlaceId";

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
        public string SelectedPlaceId { get; set; }

        public string SelectedPlaceName { get; set; }

        public string DefaultSelectedValue { get; set; }

        public string PlaceHolder { get; set; }

        public string HtmlFieldPrefix { get; set; }

        public string SelectCallBack { get; set; }

        public string SelectedCityDetailsId { get; set; }

        public string SelectedPlaceIdFieldId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(HtmlFieldPrefix))
                {
                    return HtmlFieldPrefix + "_" + SelectedPlaceIdSuffix;
                }
                else
                {
                    return SelectedPlaceIdSuffix;
                }

            }
        }
        
    }
}