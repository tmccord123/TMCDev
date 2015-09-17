namespace TMC.BusinessFacade
{
    using System.Collections.Generic;
    using System.Data;

    using TMC.Shared;

    /// <summary>
    /// The user facade.
    /// </summary>
    public class CommonFacade : FacadeBase, ICommonFacade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacade"/> class.
        /// </summary>
        public CommonFacade()
            : base(FacadeType.Common)
        {
      
        }

        /// <summary>
        /// The get cities.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<ICityDTO>> GetCities()
        {
            var commonBDC = (ICommonBDC)BDCFactory.Instance.Create(BDCType.Common);
            return commonBDC.GetCities();
        }

        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<ICategoryDTO>> GetCategories()
        {

            var commonBDC = (ICommonBDC)BDCFactory.Instance.Create(BDCType.Common);
            return commonBDC.GetCategories();
        }
    }
}