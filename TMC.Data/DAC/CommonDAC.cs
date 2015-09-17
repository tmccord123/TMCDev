
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
                throw new DACException("Error while fetching the cities.", ex);
            }

            return cities;
        }



        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// Fetch list of categories <see cref=""/>.
        /// </returns>
        public IList<ICategoryDTO> ReadCategories()
        {
            IList<ICategoryDTO> categories = new List<ICategoryDTO>();

            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var categoryEntities = (from category in tmcContext.Category select category).ToList();
                    ICategoryDTO categoryDto = null;
                    foreach (var categoryEntity in categoryEntities)
                    {
                        categoryDto = (ICategoryDTO)DTOFactory.Instance.Create(DTOType.Category);

                        categoryDto.CategoryId = categoryEntity.CategoryId;
                        categoryDto.Name = categoryEntity.Name;
                        categoryDto.ShortName = categoryEntity.ShortName;
                        categoryDto.Description = categoryEntity.Description;
                        categoryDto.Popularity = categoryEntity.Popularity;

                        categories.Add(categoryDto);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the categories.", ex);
            }

            return categories;
        }
        #endregion
    

}
}