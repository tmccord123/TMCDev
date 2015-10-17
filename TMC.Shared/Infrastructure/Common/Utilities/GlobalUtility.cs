namespace TMC.Shared
{
    /// <summary>
    /// Provides static utility methods.
    /// Author : Nagarro
    /// </summary>
    public static class GlobalUtility
    {
        /// <summary>
        /// The city value.
        /// </summary>
        private const int CityValue = 6;

        /// <summary>
        /// The default radius.
        /// </summary>
        private const int DefaultRadius = 7;

        /// <summary>
        /// Get full name with given seperator
        /// </summary>
        /// <param name="populationClass">
        /// The population Class.
        /// </param>
        /// <returns>
        /// </returns>
        public static int GetCityRadius(short? populationClass)
        {
            int retVal = 0;
            
            switch (populationClass)
            {
                case 1:
                    retVal = GetRadius(1);
                    break;
                case 2:
                    retVal = GetRadius(2);
                    break;
                case 3:
                    retVal = GetRadius(3);
                    break;
                case 4:
                    retVal = GetRadius(4);
                    break;
                case 5:
                    retVal = GetRadius(5);
                    break;
                default:
                    retVal = DefaultRadius * 1000;
                    break;
            }
            return retVal;
        }

        /// <summary>
        /// The get radius.
        /// </summary>
        /// <param name="populationClass">
        /// The population class.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int GetRadius(short populationClass)
        {
            return ((CityValue - populationClass) * DefaultRadius) * 1000;
        }
    }
}