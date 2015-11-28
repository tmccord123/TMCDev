using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity; 
using TMC.WebAPI.Entities;
using TMC.WebAPI.Models;

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