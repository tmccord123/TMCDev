using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMC.Shared;

namespace TMC.Shared
{
    public interface IBlogDTO : IDTO
    {
          /// <summary>
        /// Get or set Action Id.
        /// </summary>
        string BlogId { get; set; }  
        
        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// Get or set Action Name.
        /// </summary>
        string WebURL { get; set; }

        /// <summary>
        /// Get or set Description.
        /// </summary>
        string Description { get; set; }
    }
}