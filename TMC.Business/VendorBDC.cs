
namespace TMC.Business
{
    #region Namespaces

    using System;
    using System.Collections.Generic;

    using TMC.Shared;


    #endregion

    /// <summary>
    /// Class ProjectEmployeeBDC.
    /// </summary>
    public class VendorBDC : BDCBase, IVendorBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TMC.Business.ProductBDC"/> class.
        /// </summary>
        public VendorBDC()
            : base(BDCType.Vendor)
        { }

        #endregion

        #region Public Methods

        

        public OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId)
        {
            throw new NotImplementedException();
        }     
        
        #endregion


      
    }
}
