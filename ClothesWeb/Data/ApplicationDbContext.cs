using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites.types;
using ClothesWeb.Data.ProductEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothesWeb.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seed models and makes
            builder.Entity<Category>().HasData(
                new Category { Id = 1,ClothingCategory = Entites.types.enums.ClothingCategory.Shoes },
                 new Category { Id = 2, ClothingCategory = Entites.types.enums.ClothingCategory.Pants },
                  new Category { Id = 3, ClothingCategory = Entites.types.enums.ClothingCategory.PoloTShirts },
                   new Category { Id = 4, ClothingCategory = Entites.types.enums.ClothingCategory.CoatsJackets },
                    new Category { Id = 5, ClothingCategory = Entites.types.enums.ClothingCategory.Suits },
                     new Category { Id = 6, ClothingCategory = Entites.types.enums.ClothingCategory.Sweater });

            base.OnModelCreating(builder);
        }

        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Suits> Suits { get; set; }
        public DbSet<Pants> Pants { get; set; }
        public DbSet<Coats_jackets> Coats { get; set; }
        public DbSet<Sweater> Sweater { get; set; }
        public DbSet<Polo_TShirts> Shirts { get; set; }
        public DbSet<Designers> Designers { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}