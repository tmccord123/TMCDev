using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingMediasViewModel : ViewModelBase
    {
        public ListingMediasViewModel()
        {
            Medias = new List<MediaViewModel>();
            NewMedia = new MediaViewModel();
        }
        public List<MediaViewModel> Medias { get; set; }
        public MediaViewModel NewMedia { get; set; }
    }
}