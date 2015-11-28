using TMC.Web.Shared.Models;
using TMC.WebAPI.Entities;
using TMC.WebAPI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMC.WebAPI
{

    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;
        public UserManager<ApplicationUser> UserManager { get; private set; }//todo move models to Web.Shared

        public AuthRepository()
        {
            _ctx = new AuthContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }

        public async Task<IdentityResult> RegisterUser(RegisterViewModel userModel)
        {
            var user = new ApplicationUser()
            {
                UserName = userModel.MobileNo,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
                MobileNo = userModel.MobileNo
            };
            var result = await UserManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<IdentityResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            IdentityResult result = await UserManager.ChangePasswordAsync(changePasswordViewModel.UserName, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
            return result;
        }
        public async Task<IdentityResult> UpdateProfile(UserProfileViewModel userProfileViewModel)
        {
            ApplicationUser appUserModel = UserManager.FindById(userProfileViewModel.UserName);
            appUserModel.Email = userProfileViewModel.Email;
            appUserModel.MobileNo = userProfileViewModel.MobileNo;
            appUserModel.UserName = userProfileViewModel.MobileNo;
            IdentityResult result = await UserManager.UpdateAsync(appUserModel);
            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await UserManager.FindAsync(userName, password);
            return user;
        }

        public Client FindClient(string clientId)
        {
            var client = _ctx.Clients.Find(clientId);
            return client;
        }

        public async Task<bool> AddRefreshToken(RefreshToken token)
        {
            var existingToken = _ctx.RefreshTokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).SingleOrDefault();
            if (existingToken != null)
            {
                var result = await RemoveRefreshToken(existingToken);
            }

            _ctx.RefreshTokens.Add(token);

            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            if (refreshToken != null)
            {
                _ctx.RefreshTokens.Remove(refreshToken);
                return await _ctx.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            _ctx.RefreshTokens.Remove(refreshToken);
            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            return refreshToken;
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return _ctx.RefreshTokens.ToList();
        }

        public async Task<IdentityUser> FindAsync(UserLoginInfo loginInfo)
        {
            IdentityUser user = await UserManager.FindAsync(loginInfo);

            return user;
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user)
        {
            var result = await UserManager.CreateAsync(user);

            return result;
        }

        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login)
        {
            var result = await UserManager.AddLoginAsync(userId, login);

            return result;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            UserManager.Dispose();
        }
    }
}