using Marmot.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marmot.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // add customization code AFTER base.OnModelCreating(builder)

            builder.Entity<ApplicationUser>().ToTable("AppUser");
            builder.Entity<IdentityRole>().ToTable("AppRole");
            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaim");
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRole");
            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogin");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaim");
            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserToken");
        }
    }
}
