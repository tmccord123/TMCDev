using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.Shared.ViewModels
{
    public class ListingMediasViewModel : ViewModelBase
    {
        public ListingMediasViewModel()
        {
            Medias = new List<MediaViewModel>(); 
        }
        public List<MediaViewModel> Medias { get; set; } 
    }
}