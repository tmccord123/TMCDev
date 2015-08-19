
using TMC.Shared;

namespace TMC.Shared
{
    /// <summary>
    /// DTO Type
    /// </summary>
    public enum DTOType
    {
        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// The User DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.UserDTO")]
        User = 1,

        /// <summary>
        /// The File DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.FileDTO")]
        File = 2,

        /// <summary>
        /// The Product DTO
        /// </summary>
        [QualifiedTypeName("TMC.DTOModel.dll", "TMC.DTOModel.ProductDTO")]
        Product = 3,
    }
}
