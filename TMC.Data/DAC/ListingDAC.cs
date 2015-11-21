
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
                                           //join loc in tmcContext.ListingLocation on listing.ListingId equals loc.ListingId
                                           //join area in tmcContext.Area on loc.AreaId equals area.AreaId
                                           //where loc.CityId == cityId
                                           //&& area.CityId == cityId
                                           //&& (placeId == null || area.PlaceId == placeId)
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

                                           where listing.UserId == userId
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

        public IListingDTO GetContactsByListingId(int listingId)
        {
            IListingDTO listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            IListingContactsDTO listingContactsDto = (IListingContactsDTO)DTOFactory.Instance.Create(DTOType.ListingContacts);
            listingContactsDto.Contacts = new List<IContactDTO>();
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingcontactEntities = (from listingContact in tmcContext.ListingContact
                                                  where listingContact.ListingId == listingId && listingContact.IsActive
                                                  select listingContact).ToList();
                    if (listingcontactEntities.Any())
                    {
                        foreach (var listingContactEntity in listingcontactEntities)
                        {
                            IContactDTO listingContactDto = (IContactDTO)DTOFactory.Instance.Create(DTOType.Contact);
                            EntityConverter.FillDTOFromEntity(listingContactEntity, listingContactDto);
                            listingContactsDto.Contacts.Add(listingContactDto);
                        }
                        listingDto.ListingContacts = listingContactsDto;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing contacts.", ex);
            }

            return listingDto;
        }

        public IListingDTO GetCategoriesByListingId(int listingId)
        {
            IListingDTO listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            IListingCategoriesDTO listingCategoriesDto = (IListingCategoriesDTO)DTOFactory.Instance.Create(DTOType.ListingCategories);
            listingCategoriesDto.Categories = new List<ICategoryDTO>();
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingcategoriesEntities = (from listingCategory in tmcContext.ListingCategory
                                                     join category in tmcContext.Category on listingCategory.CategoryId equals category.CategoryId
                                                     where listingCategory.ListingId == listingId
                                                     select new
                                                     {
                                                         category,
                                                         ListingCategoryId = listingCategory.ListingCategoryId,
                                                         ListingId = listingCategory.ListingId

                                                     }).ToList();
                    if (listingcategoriesEntities.Any())
                    {
                        foreach (var listingCategoryEntity in listingcategoriesEntities)
                        {
                            ICategoryDTO categoryDto = (ICategoryDTO)DTOFactory.Instance.Create(DTOType.Category);
                            EntityConverter.FillDTOFromEntity(listingCategoryEntity.category, categoryDto);
                            categoryDto.ListingId = listingCategoryEntity.ListingId;
                            categoryDto.ListingCategoryId = listingCategoryEntity.ListingId;
                            listingCategoriesDto.Categories.Add(categoryDto);
                        }
                        listingDto.ListingCategories = listingCategoriesDto;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing contacts.", ex);
            }

            return listingDto;
        }

        public IListingDTO GetServiceLocationsByListingId(int listingId)
        {
            IListingDTO listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            IListingServiceLocationsDTO listingServiceLocationsDto = (IListingServiceLocationsDTO)DTOFactory.Instance.Create(DTOType.ListingServiceLocations);
            listingServiceLocationsDto.ServiceLocations = new List<IServiceLocationDTO>();
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingServiceLocationEntities = (from listingServiceLocation in tmcContext.ListingServiceLocation
                                                          join city in tmcContext.City on listingServiceLocation.CityId equals city.CityId
                                                          where listingServiceLocation.ListingId == listingId && listingServiceLocation.IsActive
                                                          select new
                                                          {
                                                              listingServiceLocation,
                                                              CityName = city.Name,
                                                          }).ToList();
                    if (listingServiceLocationEntities.Any())
                    {
                        foreach (var listingServiceLocationEntity in listingServiceLocationEntities)
                        {
                            IServiceLocationDTO serviceLocationDto = (IServiceLocationDTO)DTOFactory.Instance.Create(DTOType.ServiceLocation);
                            EntityConverter.FillDTOFromEntity(listingServiceLocationEntity.listingServiceLocation, serviceLocationDto);
                            serviceLocationDto.CityName = listingServiceLocationEntity.CityName;
                            listingServiceLocationsDto.ServiceLocations.Add(serviceLocationDto);
                        }
                        listingDto.ListingServiceLocations = listingServiceLocationsDto;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing contacts.", ex);//todo
            }

            return listingDto;
        }

        public IListingDTO GetPaymentModesByListingId(int listingId)
        {
            IListingDTO listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            IListingPaymentModesDTO listingPaymentModesDto = (IListingPaymentModesDTO)DTOFactory.Instance.Create(DTOType.ListingPaymentModes);
            listingPaymentModesDto.PaymentModes = new List<IPaymentModeDTO>();
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingpaymentModeEntities = (from paymentMode in tmcContext.ListingPaymentMode
                                                      where paymentMode.ListingId == listingId
                                                      select paymentMode).ToList();
                    if (listingpaymentModeEntities.Any())
                    {
                        foreach (var paymentModeEntity in listingpaymentModeEntities)
                        {
                            IPaymentModeDTO paymentModeDto = (IPaymentModeDTO)DTOFactory.Instance.Create(DTOType.PaymentMode);
                            EntityConverter.FillDTOFromEntity(paymentModeEntity, paymentModeDto);
                            listingPaymentModesDto.PaymentModes.Add(paymentModeDto);
                        }
                        listingDto.ListingPaymentModes = listingPaymentModesDto;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing payment modes.", ex);
            }

            return listingDto;
        }

        public IListingDTO GetMediasByListingId(int listingId)
        {
            IListingDTO listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            IListingMediasDTO listingMediasDto = (IListingMediasDTO)DTOFactory.Instance.Create(DTOType.ListingMedias);
            listingMediasDto.Medias = new List<IMediaDTO>();
            try
            {
                using (var tmcContext = new TMCContext())
                {
                    var listingMediaEntities = (from listingMedia in tmcContext.ListingMedia
                                                join file in tmcContext.File on listingMedia.ListingId equals file.FileId
                                                where listingMedia.ListingId == listingId && listingMedia.IsActive
                                                select new
                                                {
                                                    listingMedia,
                                                    FileName = file.OriginalFileName
                                                }).ToList();
                    if (listingMediaEntities.Any())
                    {
                        foreach (var listingMediaEntity in listingMediaEntities)
                        {
                            IMediaDTO listingMediaDto = (IMediaDTO)DTOFactory.Instance.Create(DTOType.Media);
                            EntityConverter.FillDTOFromEntity(listingMediaEntity.listingMedia, listingMediaDto);
                            listingMediaDto.FileName = listingMediaEntity.FileName;
                            listingMediasDto.Medias.Add(listingMediaDto);
                        }
                        listingDto.ListingMedias = listingMediasDto;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the listing medias.", ex);
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
                            listing.Address = "Default Address";
                            listing.PinCode = 12345;
                            listing.UserId = 3;
                            listing.CityId = 111;
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

        public IMediaDTO CreateListingMedia(IFileDTO fileDto)
        {
            IMediaDTO mediaDto = (IMediaDTO)DTOFactory.Instance.Create(DTOType.Media);
            try
            {
                if (fileDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var fileEntity = new File();
                            //EntityConverter.FillEntityFromDTO(fileDto, fileEntity);
                            fileEntity.CreatedOn = DateTime.Now;
                            fileEntity.CreatedBy = 11;
                            fileEntity.UpdatedOn = DateTime.Now;
                            fileEntity.UpdatedBy = 11;
                            fileEntity.IsActive = true;
                            fileEntity.IsDeleted = false;
                            fileEntity.FileTitle = fileDto.FileTitle;
                            fileEntity.OriginalFileName = fileDto.OriginalFileName;
                            fileEntity.ServerFileName = fileDto.ServerFileName;
                            fileEntity.ServerPath = fileDto.ServerPath;
                            fileEntity.FileExtensionId = fileDto.FileExtensionId;
                            fileEntity.FileTypeId = fileDto.FileTypeId;
                            TMCDbContext.File.AddObject(fileEntity);
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                fileDto.FileId = fileEntity.FileId;
                                var listingMediaEntity = new ListingMedia();
                                //EntityConverter.FillEntityFromDTO(fileDto, fileEntity);//todo do later
                                listingMediaEntity.CreatedOn = DateTime.Now;
                                listingMediaEntity.CreatedBy = 11;
                                listingMediaEntity.UpdatedOn = DateTime.Now;
                                listingMediaEntity.UpdatedBy = 11;
                                listingMediaEntity.IsActive = true;
                                listingMediaEntity.IsDeleted = false;
                                listingMediaEntity.ListingId = fileDto.ListingId;
                                listingMediaEntity.FileId = fileDto.FileId;
                                TMCDbContext.ListingMedia.AddObject(listingMediaEntity);
                                if (TMCDbContext.SaveChanges() > 0)
                                {
                                    mediaDto.ListingMediaId = listingMediaEntity.ListingMediaId;
                                    mediaDto.FileId = listingMediaEntity.FileId;
                                    mediaDto.FileName = fileDto.OriginalFileName;

                                }
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
            return mediaDto;
        }

        public long CreateListingCategory(ICategoryDTO categoryDto)
        {
            long retVal = GlobalConstants.DefaultCreateId;
            try
            {
                if (categoryDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var listingCategory = new ListingCategory();
                            listingCategory.ListingId = categoryDto.ListingId;
                            listingCategory.CategoryId = categoryDto.CategoryId;
                            TMCDbContext.ListingCategory.AddObject(listingCategory);
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                retVal = listingCategory.ListingCategoryId;
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
            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentModes"></param>
        /// <returns></returns>
        public int AddUpdateListingPaymentModes(IListingPaymentModesDTO paymentModes)
        {
            int retVal = 0;
            try
            {
                if (paymentModes != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            foreach (var paymentModeDto in paymentModes.PaymentModes)
                            {
                                long listingPaymentModeId = paymentModeDto.ListingPaymentModeId;
                                if (paymentModeDto.ListingPaymentModeId > 0)
                                {
                                    var listingPaymentModeEntity =
                                        TMCDbContext.ListingPaymentMode.SingleOrDefault(
                                            pmode => pmode.ListingPaymentModeId == listingPaymentModeId);
                                    if (listingPaymentModeEntity != null)
                                    {
                                        TMCDbContext.ListingPaymentMode.DeleteObject(listingPaymentModeEntity);
                                    }

                                }
                                else
                                {
                                    var listingPaymentMode = new ListingPaymentMode();
                                    EntityConverter.FillEntityFromDTO(paymentModeDto, listingPaymentMode);
                                    TMCDbContext.ListingPaymentMode.AddObject(listingPaymentMode);
                                }
                            }

                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                retVal = 1;
                            }
                        }
                        trans.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while updating listing payment modes.", ex);
            }
            return retVal;
        }

        public long CreateListingServiceLocation(IServiceLocationDTO serviceLocationDto)
        {
            long retVal = GlobalConstants.DefaultCreateId;
            try
            {
                if (serviceLocationDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var listingServiceLocation = new ListingServiceLocation();
                            listingServiceLocation.ListingId = serviceLocationDto.ListingId;
                            listingServiceLocation.CityId = serviceLocationDto.CityId;
                            TMCDbContext.ListingServiceLocation.AddObject(listingServiceLocation);

                            //todo fill these calues
                            listingServiceLocation.StateId = 1;
                            listingServiceLocation.CountryId = 1;
                            listingServiceLocation.IsCityLevel = true;
                            listingServiceLocation.CreatedOn = DateTime.Now;
                            listingServiceLocation.CreatedBy = 11;
                            listingServiceLocation.UpdatedOn = DateTime.Now;
                            listingServiceLocation.UpdatedBy = 11;
                            listingServiceLocation.IsActive = true;
                            listingServiceLocation.IsDeleted = false;
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                retVal = listingServiceLocation.ListingServiceLocationId;
                            }
                        }
                        trans.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while creating the listing detail.", ex);//todo
            }
            return retVal;
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

                            EntityConverter.FillEntityFromDTO(listingDto, listingEntity);
                            listingEntity.UpdatedOn = DateTime.Now;
                            listingEntity.CreatedOn = DateTime.Now;
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

        public string DeleteListingMedia(long listingMediaid)
        {
            string retVal = "";
            try
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    using (TMCContext tmcContext = new TMCContext())
                    {
                        ListingMedia listingMediaEntity = tmcContext.ListingMedia.SingleOrDefault(equipmentTypeField =>
                                                                      equipmentTypeField.ListingMediaId == listingMediaid); //todo check 
                        File fileEntity = tmcContext.File.SingleOrDefault(equipmentTypeField =>
                                                                      equipmentTypeField.FileId == listingMediaEntity.FileId);

                        if (listingMediaEntity != null)
                        {
                            tmcContext.DeleteObject(listingMediaEntity);
                            tmcContext.DeleteObject(fileEntity);
                            tmcContext.SaveChanges();
                            retVal = fileEntity.ServerFileName;//todo check for null
                        }
                    }
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while deleting listing media.", ex);
            }
            return retVal;
        }
    }
}