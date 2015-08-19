
namespace TMC.Web.ViewModels
{
    #region Namespaces
    using TMC.Web.Shared;
    
    #endregion

    /// <summary>
    /// Model for user settings
    /// </summary>
    public class UserSettingModel: ViewModelBase
    {
        /// <summary>
        /// Gets or sets the default company id.
        /// </summary>
        /// <value>
        /// The default company id.
        /// </value>
        public int DefaultCompanyId { get; set; }

        /// <summary>
        /// Gets or sets the default module id.
        /// </summary>
        /// <value>
        /// The default module id.
        /// </value>
        public int DefaultModuleId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is external module.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is external module; otherwise, <c>false</c>.
        /// </value>
        public bool IsExternalModule { get; set; }
    }
}