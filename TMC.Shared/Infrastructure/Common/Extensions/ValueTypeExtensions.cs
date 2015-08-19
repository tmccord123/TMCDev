using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TMC.Shared
{
    /// <summary>
    /// Provides extension utility methods for ValueType
    /// Author : Nagarro 
    /// </summary>
    public static class ValueTypeExtensions
    {
        public static bool IsDefault<T>(this T obj) where T : struct
        {
            bool retVal = false;

            retVal = obj.Equals(default(T));

            return retVal;
        }
    }
}