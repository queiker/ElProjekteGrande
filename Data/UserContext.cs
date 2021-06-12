using El_Projekte_Grande.Models;
using Microsoft.EntityFrameworkCore;

namespace El_Projekte_Grande.Data
{
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :base(options)
        {
            
        }

        public DbSet<User> Users { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.HasIndex(e => e.Email).IsUnique(); });
        }
    }
}