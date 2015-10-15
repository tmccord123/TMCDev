﻿
using System.Data.Entity.Migrations;
using EntityDataModel.EntityModels;
using TMC.EntityDataModel;
using TMC.Shared.Factories;
using System.Transactions;
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
    public class ListingDAC : DACBase, IListingDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonDAC"/> class.
        /// </summary>
        public ListingDAC()
            : base(DACType.Listing)
        {
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// The read listings.
        /// </summary>
        /// <param name="cityId">
        /// The city id.
        /// </param>
        /// <param name="placeId">
        /// The place id.
        /// </param>
        /// <param name="categoryId">
        /// The category id.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<IListingDTO> ReadListings(int cityId, string placeId, int categoryId)
        {
            IList<IListingDTO> listings = new List<IListingDTO>();

            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingEntities = (from listing in tmcContext.Listing
                                           join loc in tmcContext.ListingLocation on listing.ListingId equals loc.ListingId
                                           join area in tmcContext.Area on loc.AreaId equals area.AreaId
                                           where loc.CityId == cityId
                                           && area.CityId == cityId
                                           && (placeId == null || area.PlaceId == placeId)
                                           select listing).ToList();
                    IListingDTO listingDto = null;
                    foreach (var listingEntity in listingEntities)
                    {
                        listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);

                        listingDto.ListingId = listingEntity.ListingId;
                        listingDto.BusinessName = listingEntity.BusinessName;
                        listingDto.BusinessDays = listingEntity.BusinessDays;
                        listingDto.BusinessHours = listingEntity.BusinessHours;
                        listingDto.ContactPerson = listingEntity.ContactPerson;
                        listingDto.ContactEmailId = listingEntity.ContactEmailId;
                        listingDto.Designation = listingEntity.Designation;
                        listingDto.Website = listingEntity.Website;
                        listingDto.YearStarted = listingEntity.YearStarted;
                        listings.Add(listingDto);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listings.", ex);
            }

            return listings;
        }

        public IList<IListingDTO> GetListingsByUserId(int userId)
        {
            IList<IListingDTO> listings = new List<IListingDTO>();

            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingEntities = (from listing in tmcContext.Listing
                                           join vendor in tmcContext.Vendor on listing.VendorId equals vendor.VendorId
                                           where vendor.UserId == userId
                                           select listing).ToList();
                    IListingDTO listingDto = null;
                    foreach (var listingEntity in listingEntities)
                    {
                        listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);//todo

                        listingDto.ListingId = listingEntity.ListingId;
                        listingDto.BusinessName = listingEntity.BusinessName;
                        listingDto.Website = listingEntity.Website;
                        listings.Add(listingDto);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listings.", ex);
            }

            return listings;
        }

        public IListingDTO GetListingById(int listingId)
        { 
            IListingDTO listingDto = null;
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingEntity = (from listing in tmcContext.Listing
                                         where listing.ListingId == listingId && listing.IsActive
                                         select listing).Single();
                   
                    listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);

                    listingDto.ListingId = listingEntity.ListingId;
                    listingDto.BusinessName = listingEntity.BusinessName;
                    listingDto.BusinessDays = listingEntity.BusinessDays;
                    listingDto.BusinessHours = listingEntity.BusinessHours;
                    listingDto.ContactPerson = listingEntity.ContactPerson;
                    listingDto.ContactEmailId = listingEntity.ContactEmailId;
                    listingDto.Designation = listingEntity.Designation;
                    listingDto.Website = listingEntity.Website;
                    listingDto.YearStarted = listingEntity.YearStarted;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing detail.", ex);
            }

            return listingDto;
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
                            EntityConverter.FillEntityFromDTO(listingDto, listing);
                            listing.CreatedOn = DateTime.Now;
                            listing.CreatedBy = 11;
                            listing.UpdatedOn = DateTime.Now;
                            listing.UpdatedBy = 11;
                            listing.IsActive = true;
                            listing.IsDeleted = false;
                            TMCDbContext.Listing.AddObject(listing);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listingDto"></param>
        /// <returns></returns>
        public IListingDTO UpdateListing(IListingDTO listingDto)
        {
            try
            {
                if (listingDto != null)
                {

                    using (var TMCDbContext = new TMCContext())
                    {
                        var listingEntity = (from listing in TMCDbContext.Listing
                                             where listing.ListingId == listingDto.ListingId
                                             select listing).Single();
                        if (listingEntity != null)
                        {
                            listingEntity.UpdatedOn = DateTime.Now;
                            EntityConverter.FillEntityFromDTO(listingDto, listingEntity);
                        }
                        if (TMCDbContext.SaveChanges() > 0)
                        {
                            listingDto.ListingId = listingEntity.ListingId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while updating the listing detail.", ex);
            }
            return listingDto;
        }
    }
}