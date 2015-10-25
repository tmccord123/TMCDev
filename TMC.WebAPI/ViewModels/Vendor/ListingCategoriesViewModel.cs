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
            CategorySayt = new CategorySaytViewModel();
        }
        public List<CategoryViewModel> Categories { get; set; }
        public CategoryViewModel NewCategory { get; set; }
        public CategorySaytViewModel CategorySayt { get; set; }
    }
}