using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TMC.Web.Models;
using TMC.WebAPI.Entities;

namespace TMC.WebAPI
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext(): base("DefaultConnection")
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}