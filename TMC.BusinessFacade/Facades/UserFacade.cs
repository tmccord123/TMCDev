namespace TMC.BusinessFacade
{
    using System.Collections.Generic;
    using System.Data;

    using TMC.Shared;

    /// <summary>
    /// The user facade.
    /// </summary>
    public class UserFacade : FacadeBase, IUserFacade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacade"/> class.
        /// </summary>
        public UserFacade()
            : base(FacadeType.User)
        {

      
        }

        public OperationResult<IUserDTO> GetUserById(int userId)
        { 
            var userBDC = (IUserBDC) BDCFactory.Instance.Create(BDCType.User);
            return userBDC.GetUserById(userId);
        }


        public OperationResult<long> CreateUser(IUserDTO userDto)
        {
            var userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.User);
            return userBDC.CreateUser(userDto);
        }
 
    }
}