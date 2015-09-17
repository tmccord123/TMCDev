
namespace TMC.Shared
{
    /// <summary>
    /// The CategoryDTO interface.
    /// </summary>
    public interface ICategoryDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        int? Popularity { get; set; }
    }
}
