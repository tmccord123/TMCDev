
using System.Data.Entity.Migrations;
using EntityDataModel.EntityModels;
using TMC.Shared.Factories;

namespace TMC.Data
{
    #region Namespaces

    using System;
    using System.Collections.Generic;
    using System.Linq; 
    using TMC.Shared;
 

    #endregion

    /// <summary>
    /// Implementation for 
    /// </summary>
    public class UserDAC : DACBase, IUserDAC
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDAC"/> class.
        /// </summary>
        public UserDAC()
            : base(DACType.User)
        {
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Create Help
        /// </summary>
        /// <returns> long</returns> 
        public IUserDTO GetUserById(int userId)
        {
            
            var userDto = (IUserDTO)DTOFactory.Instance.Create(DTOType.User);
            try
            {
                userDto.AddressLine1 = "this is the address line 1";
                userDto.AddressLine2 = "this is the address line 2";
                userDto.UserName = "user1";
                userDto.FirstName = "Vikash";
                userDto.LastName = "Kumar";
            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
                //throw new DACException("Error while fetching the organization locations.", ex);
            }
            return userDto;
        }

        
        #endregion
    }
}