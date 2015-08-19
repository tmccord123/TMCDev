
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
    public class ProductDAC : DACBase, IProductDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDAC"/> class.
        /// </summary>
        public ProductDAC()
            : base(DACType.Product)
        {
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Create Help
        /// </summary>
        /// <returns> long</returns>
        public long CreateProduct(IProductDTO productDto)
        {
            long helpMasterID = int.MinValue;
            using (var tmcDBContext = new TMCContext())
            {
                var productItem = (from product in tmcDBContext.Products
                                where product.ProductId == 1 && product.IsActive == true
                    select product).SingleOrDefault();
                productItem.Content = productDto.Content;
                productItem.ContentText = productDto.ContentText;
                //productItem.IsActive = false; 
                tmcDBContext.Products.AddOrUpdate(productItem);
                tmcDBContext.SaveChanges();
            }
        
        

        /* try
            {
                using (IDatabase db = DatabaseFactory.CreateDatabase())
                {
                    db.Connect();
                    db.BeginTransaction();
                    db.CreateDBCommand(DatabaseConstants.Procedures.prc_ins_tbl_HelpMaster, System.Data.CommandType.StoredProcedure);

                    db.AddParameter("HELPMASTERID", DbType.Int64, (object)help.HelpMasterID, ParameterDirection.InputOutput);
                    db.AddParameter("PRODUCTID", DbType.Int32, HelpDAC.ValidateDataObject(help.ProductID));
                    db.AddParameter("SITEID", DbType.Int32, HelpDAC.ValidateDataObject(help.SiteID));
                    db.AddParameter("ISFOLDER", DbType.Boolean, HelpDAC.ValidateDataObject(help.IsFolder));
                    db.AddParameter("PARENTCODE", DbType.String, HelpDAC.ValidateDataObject(help.ParentCode));
                    db.AddParameter("TITLE", DbType.String, HelpDAC.ValidateDataObject(help.Title));
                    db.AddParameter("CONTENT", DbType.String, HelpDAC.ValidateDataObject(help.Content));
                    db.AddParameter("CONTENTTEXT", DbType.String, HelpDAC.ValidateDataObject(help.ContentText));
                    db.AddParameter("HELPCODE", DbType.String, HelpDAC.ValidateDataObject(help.HelpCode));
                    db.AddParameter("LANGUAGEID", DbType.Int32, HelpDAC.ValidateDataObject(help.LanguageID));
                    db.AddParameter("CREATEDBY", DbType.Int64, HelpDAC.ValidateDataObject(help.CreatedBy));

                    db.ExecuteNonQuery();
                    helpMasterID = db.GetOutputParameterValue<long>("HELPMASTERID");

                    if (helpMasterID > 0)
                    {
                        db.Commit();
                    }
                    else
                    {
                        db.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("An exception Saving Help", ex);
            }*/
            return 1;
        }
        public List<IProductDTO> ReadAllProducts()
        {
            List<IProductDTO> productList = new List<IProductDTO>();

            try
            {
                if (1 > 0)
                {
                    using (var tmcDBContext = new TMCContext())
                    {
                        var products = (from blog in tmcDBContext.Products
                                                     select blog).ToList();
                        foreach (var product in products)
                        {
                            var productDTO = (IProductDTO)DTOFactory.Instance.Create(DTOType.Product);
                            productDTO.ProductId = product.ProductId;
                            productDTO.Description = product.Description;
                            productDTO.Name = product.Name;
                            productDTO.SeoTitle = product.SeoTitle;
                            productDTO.ImageURL = product.ImageURL;

                            productList.Add(productDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
                //throw new DACException("Error while fetching the organization locations.", ex);
            }
            return productList;
        }

        public IProductDTO ReadProductBySeoTitle(string seoTitle)
        {
            var productDTO = (IProductDTO)DTOFactory.Instance.Create(DTOType.Product);
            try
            {
                if (1 > 0)
                {
                    using (var tmcDBContext = new TMCContext())
                    {
                        var product = (from blog in tmcDBContext.Products
                                        where blog.SeoTitle == seoTitle && blog.IsActive == true
                                        select blog).SingleOrDefault();
                       
                        productDTO.ProductId = product.ProductId;
                        productDTO.Description = product.Description;
                        productDTO.Name = product.Name;
                        productDTO.Content = product.Content;
                        productDTO.SeoTitle = product.SeoTitle;
                        productDTO.ImageURL = product.ImageURL;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
                //throw new DACException("Error while fetching the organization locations.", ex);
            }
            return productDTO;
        }
         

        #endregion
    }
}