

using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.Entity;
//using System.Data.Objects;
//using System.Data.Services.Client;
//using System.Linq;
//using System.ServiceModel;
//using GH.Common.Framework.Persistence;
//using GH.Common.Framework.Persistence.DataServiceCxt;
//using GH.Common.ServiceLocator;
//using TMC.Business.Entities;
//using TMC.Business.Interfaces;
//using TMC.EntityFramework;
////using GH.Northwind.Persistence.DataServiceCxt;
using TMC.Business.Interfaces;
using TMC.Shared;


namespace TMC.Business
{
    /*using ObjectCxtNamespace = Persistence.ObjectCxt;
    using DbCxtNamespace = Persistence.DbCxt;
    using DataServiceCxtNamespace = Persistence.DataServiceCxt;
    using ObjectCxtFrameWkNamespace = Common.Framework.Persistence.ObjectCxt;
    using DbCxtFrameWkNamespace = Common.Framework.Persistence.DbCxt;
    using DataServiceCxtFrameWkNamespace = Common.Framework.Persistence.DataServiceCxt;*/
using System.ServiceModel;

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall)]
    public class TMCSvr : ITMCSvr
    {
        static TMCSvr()
        {




            //Common.Framework.Persistence.DbCxt.DataCxt.Cxt = new NorthwindEntities();
            //ServiceLocator<IPersistence<Product>>.RegisterService<Persistence.DbCxt.ProductPrst>();
            /*if (typeof(NorthwindEntities).IsSubclassOf(typeof(ObjectContext)))
            {
                // Below are commented out since now NorthwindEntities is DbContext; Uncomment them out if NorthwindEntities is ObjectContext; 

                ObjectCxtFrameWkNamespace.DataCxt.Cxt = new NorthwindEntities();
                ServiceLocator<IPersistence<Product>>.RegisterService<ObjectCxtNamespace.ProductPrst>();

            }
            else if (typeof(NorthwindEntities).IsSubclassOf(typeof(DbContext)))
            {
                Common.Framework.Persistence.DbCxt.DataCxt.Cxt = new NorthwindEntities();
                ServiceLocator<IPersistence<Product>>.RegisterService<Persistence.DbCxt.ProductPrst>();
            }
            else
            {
                throw new NotSupportedException("NorthwindSvr: static Constructor: " + typeof(NorthwindEntities) +
                                                " isn't a supported type.");
            }*/
        }



        public OperationResult<IList<IProductDTO>> GetAllProducts()
        {

            OperationResult<IList<IProductDTO>> operationResult = null;
            try
            {
                var productDAC = (IProductDAC)DACFactory.Instance.Create(DACType.Product);
                var products = productDAC.ReadAllProducts();

                operationResult = products != null
                                                      ? OperationResult<IList<IProductDTO>>.CreateSuccessResult(products)
                                                      : OperationResult<IList<IProductDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Training.TrainingPlan.Index.Messages
                                                               .FailedToFetchTrainingCompanies));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<IProductDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<IProductDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult;
            //return PersistSvr<Order>.GetAll().ToList();
        }
         
    }
}