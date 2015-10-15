
using System.Data.Entity.Migrations;
using EntityDataModel.EntityModels;
using TMC.EntityDataModel;
using TMC.Shared.Factories; 
using  System.Transactions;

namespace TMC.Data
{
    #region Namespaces

    using System;
    using System.Collections.Generic;
    using System.Linq; 
    using TMC.Shared;
 

    #endregion

    /// <summary>
    /// Implementation for 
    /// </summary>
    public class VendorDAC : DACBase, IVendorDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDAC"/> class.
        /// </summary>
        public VendorDAC()
            : base(DACType.Vendor)
        {
        }
        #endregion

        #region Public Methods
 
   
        #endregion



    }
}