
namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.
    /// </summary>
    public interface IListingContactDTO : IDTO
    {
        string ContactNumber { get; set; }
        int ListingContactTypeId { get; set; }
    }
}
