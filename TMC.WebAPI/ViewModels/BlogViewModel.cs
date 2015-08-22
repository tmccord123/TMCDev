using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMC.ViewModels
{


    public class BlogViewModels
    {
        public List<BlogViewModel> Blogs { get; set; }
    }

    public class BlogViewModel
    {
        //[Required]
        //[Display(Name = "User name")]
        //public string UserName { get; set; }

        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        [Display(Name = "User name")]
        public string BlogId { get; set; }

        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Get or set Action Name.
        /// </summary>
        public string WebURL { get; set; }

        /// <summary>
        /// Get or set Description.
        /// </summary>
        public string Description { get; set; }

         
    }


}