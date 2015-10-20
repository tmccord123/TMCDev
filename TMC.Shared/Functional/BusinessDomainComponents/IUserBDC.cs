
namespace TMC.Shared
{
    /// <summary>
    /// The UserBDC interface.
    /// </summary>
    public interface IUserBDC : IBusinessDomainComponent
    {
        OperationResult<IUserDTO> GetUserById(int userId);

        OperationResult<long> CreateUser(IUserDTO userDto);
    }
}