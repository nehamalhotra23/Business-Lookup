using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Business.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Shop> Shop { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Shop>()
                .HasData(
                    new Shop { ShopId = 1, ShopName = "Los Angelos", CountryId = 1 },
                    new Shop { ShopId = 2, ShopName = "Paris", CountryId = 2 },
                    new Shop { ShopId = 3, ShopName = "Venice", CountryId = 3 },
                    new Shop { ShopId = 4, ShopName = "Hong Kong", CountryId = 4 },
                   
                );

            builder.Entity<Country>()
                .HasData(
                    new Country { CountryId = 1, CountryName = "USA" },
                    new Country { CountryId = 2, CountryName = "France" },
                    new Country { CountryId = 3, CountryName = "Italy" },
                    new Country { CountryId = 4, CountryName = "Hong Kong" },
                    new Country { CountryId = 5, CountryName = "England" },
                    new Country { CountryId = 6, CountryName = "India" },
                    new Country { CountryId = 7, CountryName = "Kenya" },
                    new Country { CountryId = 8, CountryName = "Indonesia" },
                    new Country { CountryId = 9, CountryName = "Brasil" }
                );

            builder.Entity<User>()
                .HasData(
                    new User { UserId = 3, UserName = "Dom" },
                    new User { UserId = 4, UserName = "Jen" },
                    new User { UserId = 5, UserName = "Anita" },
                    new User { UserId = 6, UserName = "Devin" },
                    new User { UserId = 7, UserName = "Hailey" },
                    new User { UserId = 8, UserName = "Neha" },
                    new User { UserId = 9, UserName = "Joel" },
                    new User { UserId = 10, UserName = "Kira" },
                    new User { UserId = 11, UserName = "Molly" },
                    new User { UserId = 12, UserName = "Sofia" }
                );

            builder.Entity<Review>()
                .HasData(
                    new Review { ReviewId = 3, Rating = 2, UserId = 3, CityId = 3, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
                    new Review { ReviewId = 4, Rating = 4, UserId = 3, CityId = 3, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
                    new Review { ReviewId = 5, Rating = 5, UserId = 4, CityId = 6, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" }
                    
                );
        }
    }
}