
namespace TMC.Shared
{
    /// <summary>
    /// Business Domain Component Type
    /// </summary>
    public enum BDCType
    {
        /// <summary>
        /// Undefined BDC (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// User BDC
        /// </summary>
        [QualifiedTypeName("TMC.Business.dll", "TMC.Business.UserBDC")]
        User = 1,

        /// <summary>
        /// User BDC
        /// </summary>
        [QualifiedTypeName("TMC.Business.dll", "TMC.Business.ProductBDC")]
        Product = 2,

        /// <summary>
        /// Vendor BDC
        /// </summary>
        [QualifiedTypeName("TMC.Business.dll", "TMC.Business.VendorBDC")]
        Vendor = 3
        
    }
}
