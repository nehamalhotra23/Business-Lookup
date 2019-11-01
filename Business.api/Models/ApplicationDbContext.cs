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

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewRestaurant> ReviewRestaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Shop>()
                .HasData(
                    new Shop { ShopId = 1, ShopName = "Flower", ShopAddress = "stark" },
                    new Shop { ShopId = 2, ShopName = "Pet", ShopAddress = "division" },
                    new Shop { ShopId = 3, ShopName = "Grocery", ShopAddress = "Sellwoood"}
                    
                 );

            builder.Entity<Restaurant>()
                .HasData(
                    new Restaurant { RestaurantId = 1, RestaurantName = "USA", RestaurantAddress = "30th street"  },
                    new Restaurant { RestaurantId = 2, RestaurantName = "France", RestaurantAddress = "20th Street" },
                    new Restaurant { RestaurantId = 3, RestaurantName = "Italy", RestaurantAddress = "40th street" }
                    
                );

            builder.Entity<User>()
                .HasData(
                    new User { UserId = 3, UserName = "Dom" },
                    new User { UserId = 4, UserName = "Jen" },
                    new User { UserId = 5, UserName = "Anita" },
                    new User { UserId = 6, UserName = "Devin" }
                    
                );

            builder.Entity<Review>()
                .HasData(
                    new Review { ReviewId = 1, UserId = 3, ShopId = 1,  Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
                    new Review { ReviewId = 2, UserId = 3, ShopId = 2, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
                    new Review { ReviewId = 3, UserId = 4, ShopId = 3, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" }
                    
                );
            builder.Entity<ReviewRestaurant>()
           .HasData(
               new ReviewRestaurant { ReviewRestaurantId = 1, UserId = 1, RestaurantId = 1, BlurbRestaurant = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
               new ReviewRestaurant { ReviewRestaurantId = 2, UserId = 3, RestaurantId = 2, BlurbRestaurant = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
               new ReviewRestaurant { ReviewRestaurantId = 3, UserId = 4, RestaurantId = 3, BlurbRestaurant = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" }

           );
        }
    }
}