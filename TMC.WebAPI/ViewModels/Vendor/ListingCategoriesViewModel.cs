using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingCategoriesViewModel : ViewModelBase
    {
        public ListingCategoriesViewModel()
        {
            Categories = new List<CategoryViewModel>();
            NewCategory = new CategoryViewModel();
        }
        public List<CategoryViewModel> Categories { get; set; }
        public CategoryViewModel NewCategory { get; set; }
    }
}