﻿
using System.Data.Entity.Migrations;
using EntityDataModel.EntityModels;
using TMC.EntityDataModel;
using TMC.Shared.Factories; 
using  System.Transactions;

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
    public class VendorDAC : DACBase, IVendorDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDAC"/> class.
        /// </summary>
        public VendorDAC()
            : base(DACType.Vendor)
        {
        }
        #endregion

        #region Public Methods
 
        public IListingDTO GetListingById(int listingId)
        {
           // var userDto = (IUserDTO)DTOFactory.Instance.Create(DTOType.User);
 	        var listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            try
            {
                //listingDto.CompanyName = "this is the contact 1";
                listingDto.ContactPerson = "this is the ontact persone mane";
               // listingDto.EmailId = "user1@email.com";
               // listingDto.City = "Banglore";
            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
                //throw new DACException("Error while fetching the organization locations.", ex);
            }
            return listingDto;
        }
        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <param name="listingDto"></param>
        /// <returns></returns>
        public IListingDTO CreateListing(IListingDTO listingDto)
        {
            try
            {
                if (listingDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var listing = new Listing();
                           // EntityConverter.FillEntityFromDTO(listingDto, listing);
                            TMCDbContext.Listing.Add(listing);
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                listingDto.ListingId = listing.ListingId;
                            }
                        }
                        trans.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while creating the listing detail.", ex);
            }
            return listingDto;
        }
    }
}