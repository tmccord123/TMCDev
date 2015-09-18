using System.Collections.Generic;

namespace TMC.Web.Shared
{
    using TMC.Shared;

    /// <summary>
    /// Represents category information.
    /// </summary>
    public class CategoryState : StateEntityBase
    {
        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public IList<ICategoryDTO> Categories { get; set; }
    }
}