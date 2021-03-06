﻿namespace TMC.Shared
{
    /// <summary>
    /// The DAC Types
    /// </summary>
    public enum DACType
    {
        /// <summary>
        /// Undefined DAC Type (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// User DAC
        /// </summary>
        [QualifiedTypeName("TMC.Data.dll", "TMC.Data.UserDAC")]
        User = 1,

        /// <summary>
        /// Product DAC
        /// </summary>
        [QualifiedTypeName("TMC.Data.dll", "TMC.Data.ProductDAC")]
        Product = 2,

        /// <summary>
        /// Vendor DAC
        /// </summary>
        [QualifiedTypeName("TMC.Data.dll", "TMC.Data.VendorDAC")]
        Vendor = 3,

        /// <summary>
        /// Common DAC
        /// </summary>
        [QualifiedTypeName("TMC.Data.dll", "TMC.Data.CommonDAC")]
        Common = 4,

        /// <summary>
        /// Listing DAC
        /// </summary>
        [QualifiedTypeName("TMC.Data.dll", "TMC.Data.ListingDAC")]
        Listing = 5,
    }
}