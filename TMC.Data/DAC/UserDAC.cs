
using System.Data.Entity.Migrations;
using System.Transactions;
using EntityDataModel.EntityModels;
using TMC.EntityDataModel;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public long CreateUser(IUserDTO userDto)
        {
            var retVal = -1L;//public const int DefaultCreateId = -1; todo add this to Global constants
            try
            {
                if (userDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var user = new User();
                            EntityConverter.FillEntityFromDTO(userDto, user);
                            user.CreatedOn = DateTime.Now;
                            user.CreatedBy = 11;//todo
                            user.UpdatedOn = DateTime.Now;
                            user.UpdatedBy = 11;
                            user.IsActive = true;
                            user.IsDeleted = false;
                            user.UserTypeId = 1;
                            user.AddressLine1 = "Default AddressLine1";
                            user.PinCode = 12345;
                            TMCDbContext.User.AddObject(user);
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                retVal = user.UserId;
                                //userDto.ListingId = listing.ListingId;
                            }
                        }
                        trans.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while creating the user.", ex);
            }
            return retVal;
        }


        public long UpdateUser(IUserDTO userDto)
        {
            var retVal = -1L;//public const int DefaultCreateId = -1; todo add this to Global constants
            try
            {
                if (userDto != null)
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        using (var TMCDbContext = new TMCContext())
                        {
                            var user = new User();
                            EntityConverter.FillEntityFromDTO(userDto, user);
                            user.CreatedOn = DateTime.Now;
                            user.CreatedBy = 11;//todo
                            user.UpdatedOn = DateTime.Now;
                            user.UpdatedBy = 11;
                            user.IsActive = true;
                            user.IsDeleted = false;
                            user.AddressLine1 = "Default AddressLine1";
                            user.PinCode = 12345;
                            user.UserTypeId = 1;
                            TMCDbContext.User.AddObject(user);
                            if (TMCDbContext.SaveChanges() > 0)
                            {
                                retVal = user.UserId;
                                //userDto.ListingId = listing.ListingId;
                            }
                        }
                        trans.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while creating the user.", ex);
            }
            return retVal;
        }
        
        #endregion
    }
}