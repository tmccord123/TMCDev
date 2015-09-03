
using System.Data.Entity.Migrations;
using EntityDataModel.EntityModels;
using TMC.Shared.Factories;

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
    public class CommonDAC : DACBase, ICommonDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonDAC"/> class.
        /// </summary>
        public CommonDAC()
            : base(DACType.Common)
        {
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// The read cities.
        /// </summary>
        /// <returns>
        /// Fetch all cities <see cref="IList"/>.
        /// </returns>
        public IList<ICityDTO> ReadCities()
        {
            IList<ICityDTO> cities = new List<ICityDTO>();
           
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var cityEntities = (from city in tmcContext.City select city).ToList();
                     ICityDTO cityDto = null;
                     foreach (var cityEntity in cityEntities)
                     {
                         cityDto = (ICityDTO)DTOFactory.Instance.Create(DTOType.City);
                        
                         cityDto.CityId = cityEntity.CityId;
                         cityDto.Name = cityEntity.Name;
                         cityDto.StateId = cityEntity.StateId;
                         cityDto.Lat = cityEntity.Lat;
                         cityDto.Long = cityEntity.Long;

                         cities.Add(cityDto);
                     }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the organization locations.", ex);
            }

            return cities;
        }
        #endregion
    

}
}