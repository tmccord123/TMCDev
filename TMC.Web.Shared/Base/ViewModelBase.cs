using System.Linq;
using TMC.Shared;

namespace TMC.Web.Shared
{
    /// <summary>
    /// The view model base class.
    /// </summary>
    public class ViewModelBase
    {
        public string Title { get; set; }

        public string Heading { get; set; }

        /// <summary>
        /// Gets or sets the action name for add edit business contact
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or sets the Controller name for add edit business contact
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// Gets or sets call back before form request begin
        /// </summary>
        public string FormBeginRequestCallBack { get; set; }

        /// <summary>
        /// Gets or sets call back after form request success
        /// </summary>
        public string FormSuccessCallBack { get; set; }

        /// <summary>
        /// Gets or sets call back after form request failure
        /// </summary>
        public string FormFailureCallBack { get; set; }

        /// <summary>
        /// Gets or sets call back after form request validation
        /// </summary>
        public string FormValidationCallBack { get; set; }

        /// <summary>
        /// Gets or sets form id of add edit business contact
        /// </summary>
        public string FormId { get; set; }

        /// <summary>
        /// Gets or sets call back for cancel button of add edit business contact form
        /// </summary>
        public string FormCancelCallBack { get; set; }
    }
}