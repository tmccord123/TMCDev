namespace TMC.Shared
{
    /// <summary>
    /// The Facade Types
    /// </summary>
    public enum FacadeType
    {
        /// <summary>
        /// Undefined Facade Type (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// User Facade
        /// </summary>
        [QualifiedTypeName("TMC.BusinessFacade.dll", "TMC.BusinessFacade.UserFacade")]
        User = 1,

        /// <summary>
        /// AccountManagement Facade
        /// </summary>
        [QualifiedTypeName("TMC.BusinessFacade.dll", "TMC.BusinessFacade.AccountManagementFacade")]
        AccountManagement = 2,

        /// <summary>
        /// User Facade
        /// </summary>
        [QualifiedTypeName("TMC.BusinessFacade.dll", "TMC.BusinessFacade.ProductFacade")]
        Product = 3,
        
        /// <summary>
        /// User Facade
        /// </summary>
        [QualifiedTypeName("TMC.BusinessFacade.dll", "TMC.BusinessFacade.VendorFacade")]
        Vendor = 4,

        /// <summary>
        /// User Facade
        /// </summary>
        [QualifiedTypeName("TMC.BusinessFacade.dll", "TMC.BusinessFacade.ListingFacade")]
        Listing = 5,
    }
}