using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.Shared.ViewModels
{
    public class ListingCategoriesViewModel : ViewModelBase
    {
        public ListingCategoriesViewModel()
        {
            Categories = new List<CategoryViewModel>();
            NewCategory = new CategoryViewModel();
            CategorySaytListing = new CategorySaytViewModel();
        }
        public List<CategoryViewModel> Categories { get; set; }
        public CategoryViewModel NewCategory { get; set; }
        public CategorySaytViewModel CategorySaytListing { get; set; }
    }
}