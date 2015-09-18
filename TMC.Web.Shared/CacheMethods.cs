using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMC.Shared;
using TMC.Shared.Factories;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Contains common methods to be cached,
    /// Author: TMC
    /// </summary>
    public static class CacheMethods
    {
        #region "Methods"
        /// <summary>
        /// This Method is used to get the list of cities and put in cache
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static IList<ICityDTO> FetchAllCities()
        {
            if (CacheManager<CityState>.Data.Cities == null)
            {
                OperationResult<IList<ICityDTO>> cities = null;
                ICommonFacade commonFacade = (ICommonFacade)FacadeFactory.Instance.Create(FacadeType.Common);
                cities = commonFacade.GetCities();
                if (cities != null && cities.IsValid())
                {
                    CacheManager<CityState>.Data.Cities = cities.Data;
                }
                else
                {
                   throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Common.ErrorMessages.FailedToFetchCities));
                }
            }
            return CacheManager<CityState>.Data.Cities;
        }

        /// <summary>
        /// This Method is used to get the list of categories and put in cache
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static IList<ICategoryDTO> FetchAllCategories()
        {
            if (CacheManager<CategoryState>.Data.Categories == null)
            {
                OperationResult<IList<ICategoryDTO>> categories = null;
                ICommonFacade commonFacade = (ICommonFacade)FacadeFactory.Instance.Create(FacadeType.Common);
                categories = commonFacade.GetCategories();
                if (categories != null && categories.IsValid())
                {
                    CacheManager<CategoryState>.Data.Categories = categories.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Common.ErrorMessages.FailedToFetchCities));
                }
            }
            return CacheManager<CategoryState>.Data.Categories;
        }

        #endregion
    }
}
