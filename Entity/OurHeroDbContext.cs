using Microsoft.EntityFrameworkCore;
using webAPIAuthExample.Model;

namespace webAPIAuthExample.Entity
{
    public class OurHeroDbContext : DbContext
    {
        public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
        {

        }

        public DbSet<OurHero> OurHeros { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

            modelBuilder.Entity<OurHero>().HasData(
                new OurHero { FirstName = "madhu", Id = 1, IsActive = true, LastName = "dharani" }

                );


            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = 1,
                   FirstName = "System",
                   LastName = "",
                   Username = "System",
                   Password = "System",
               }
           );
        }
    }
}
