﻿namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for data access component factory,
    /// Author		: TMC
    /// </summary>
    public interface IDACFactory
    {
        /// <summary>
        /// Creates the specified DAC type.
        /// </summary>
        /// <param name="type">The DAC type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        IDataAccessComponent Create(DACType type, params object[] args);
    }
}
