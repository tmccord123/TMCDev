namespace TMC.Shared
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
    }
}