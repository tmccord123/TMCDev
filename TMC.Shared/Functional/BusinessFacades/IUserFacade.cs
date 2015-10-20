
namespace TMC.Shared
{
    /// <summary>
    /// The UserFacade interface.
    /// </summary>
    public interface IUserFacade : IFacade
    {
        OperationResult<IUserDTO> GetUserById(int userId);

        OperationResult<long> CreateUser(IUserDTO userDto);
    }
}