using AppIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppIdentity.Data
{
    public class ApplicationStoreContext : IdentityDbContext<AppUser>
    {
        public ApplicationStoreContext(DbContextOptions<ApplicationStoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
