using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMC.ViewModels
{


    public class ProductViewModel
    {
        public List<ProductItemViewModel> Products { get; set; }
    }

    public class ProductItemViewModel
    {
        public int ProductId { get; set; }

        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        public string Name { get; set; }

        public string SeoTitle { get; set; }
        

        /// <summary>
        /// Get or set Action Name.
        /// </summary>
        public string SiteURL { get; set; }

        public string ImageURL { get; set; }


        /// <summary>
        /// Get or set Description.
        /// </summary>
        public string Description { get; set; }
        public string Content { get; set; }
        public string ContentText { get; set; }

         
    }


}