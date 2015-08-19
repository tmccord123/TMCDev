using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMC.Shared;

namespace TMC.Shared
{
    public interface IProductDTO : IDTO
    {
          int ProductId { get; set; }

        /// <summary>
        /// Get or set Action Id.
        /// </summary>
          string Name { get; set; }

          string SeoTitle { get; set; }
        /// <summary>
        /// Get or set Action Name.
        /// </summary>
          string SiteURL { get; set; }

          string ImageURL { get; set; }

        /// <summary>
        /// Get or set Description.
        /// </summary>
          string Description { get; set; }

          string Content { get; set; }
          string ContentText { get; set; }
    }
}