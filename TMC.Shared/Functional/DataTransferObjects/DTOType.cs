
using TMC.Shared;

namespace TMC.Shared
{
    /// <summary>
    /// DTO Type
    /// </summary>
    public enum DTOType
    {
        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// The User DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.UserDTO")]
        User = 1,

        /// <summary>
        /// The File DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.FileDTO")]
        File = 2,

        /// <summary>
        /// The Product DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ProductDTO")]
        Product = 3,

        /// <summary>
        /// The Listing DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingDTO")]
        Listing = 4,

        /// <summary>
        /// The City DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.CityDTO")]
        City = 5,

        /// <summary>
        /// The Category DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.CategoryDTO")]
        Category = 6,

        /// <summary>
        /// The Listing ContsctsDTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingContactsDTO")]
        ListingContacts = 7,

        /// <summary>
        /// The Listing ContsctDTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ContactDTO")]
        Contact = 8,

        /// <summary>
        /// The Listing ContsctsDTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingCategoriesDTO")]
        ListingCategories = 9,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingServiceLocationsDTO")]
        ListingServiceLocations = 10,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ServiceLocationDTO")]
        ServiceLocation = 11,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingPaymentModesDTO")]
        ListingPaymentModes = 12,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.PaymentModeDTO")]
        PaymentMode = 13,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ListingMediasDTO")]
        ListingMedias = 14,

        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.MediaDTO")]
        Media = 15,



        
    }
}
