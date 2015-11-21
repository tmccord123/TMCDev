
namespace TMC.Web.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The Media view model.
    /// </summary>
    public class MediaViewModel : ViewModelBase
    {
        public long ListingMediaId { get; set; }
        public long ListingId { get; set; }
        public long FileId { get; set; }
        public string FileName { get; set; }
        public string ServerFileName { get; set; }
    }
}