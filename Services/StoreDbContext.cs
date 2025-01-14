using CompanyX.Store.Domains.Entites;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddCountries(modelBuilder);
            AddCategories(modelBuilder);
        }

        private void AddCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                  .HasData(
                      new Category() { Id = 1, Name = "Sport", Description = "Sport Sport", CreatedDateTime = DateTime.Now },
                      new Category() { Id = 2, Name = "Child", Description = "Child Child", CreatedDateTime = DateTime.Now }
                  );
            ;
        }

        private void AddCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Jordan",
                        CreatedDateTime = DateTime.Now
                    },
                    new Country()
                    {
                        Id = 2,
                        Name = "KSA",
                        CreatedDateTime = DateTime.Now
                    });
        }
    }
}
