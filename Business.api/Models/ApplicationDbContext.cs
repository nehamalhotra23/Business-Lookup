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
                    new Shop { ShopId = 1, ShopName = "Anna's Flower", Type = "flower Shop", ShopAddress = "8480 SE Division St Powellhurst - Gilbert" },
                    new Shop { ShopId = 2, ShopName = "Angel's Donut and Ice Cream", Type = "Donut Shop", ShopAddress = "164th street Vancover" },
                    new Shop { ShopId = 3, ShopName = "Ace Hardware", Type = "Hardware Tools", ShopAddress = "122 ave portland 97236" },
                    new Shop { ShopId = 4, ShopName = "Lake O Flower", Type = "flower Shop", ShopAddress = "397 N State St Lake Oswego,OR 97034" },
                    new Shop { ShopId = 5, ShopName = "Target", Type = "department store", ShopAddress = "9800 SE Washington St" },
                     new Shop { ShopId = 6, ShopName = "Home Depot", Type = "hardware store", ShopAddress = "10120 SE Washington St" },
                    new Shop { ShopId = 7, ShopName = "Fred Meyer", Type = "Grocery Store", ShopAddress = "14700 SE Division st" },
                    new Shop { ShopId = 8, ShopName = "New Season", Type = "Grocery Store", ShopAddress = "4034 SE Hawthorne Blvd portland 97214" },
                    new Shop { ShopId = 9, ShopName = "Little Otsu", Type = "Gift Shop", ShopAddress = "3225 SE Division St" },
                    new Shop { ShopId = 10, ShopName = "Bi Mart", Type = "Department Store", ShopAddress = "12321 NE Halsey St" }

                 );

            builder.Entity<Restaurant>()
                .HasData(
                    new Restaurant { RestaurantId = 1, RestaurantName = "Seerato", Cuisines = "Italian", RestaurantAddress = "2112 NW Kearney St Alphabet Distric" },
                    new Restaurant { RestaurantId = 2, RestaurantName = "Portland City Grill", Cuisines = "American", RestaurantAddress = "111 5th Ave 30th Floor Portland OR 97204" },
                    new Restaurant { RestaurantId = 3, RestaurantName = "Deeny's", Cuisines = "American", RestaurantAddress = "425 NE Hassalo St Lloyd Distric" },
                    new Restaurant { RestaurantId = 4, RestaurantName = "Oliver's Cafe", Cuisines = "Breakfast and brunch", RestaurantAddress = "8931 SE Foster Rd, Ste 105, Portland" },
                    new Restaurant { RestaurantId = 5, RestaurantName = "Big's Chicken", Cuisines = "American", RestaurantAddress = "4606 NE Glisan St. Portland 97213" },
                    new Restaurant { RestaurantId = 6, RestaurantName = "Tortilleria Y Tienda De Leon's", Cuisines = "Mexican", RestaurantAddress = "162233 NE Glisan St Portland 97230" },
                    new Restaurant { RestaurantId = 7, RestaurantName = "The Waffle Window", Cuisines = "Breakfast Brunch & Waffles", RestaurantAddress = "3610 SE Hawthorne blvd Portland 97214" },
                    new Restaurant { RestaurantId = 8, RestaurantName = "Don Camaron", Cuisines = "Mexican", RestaurantAddress = "Downtown Portland" },
                    new Restaurant { RestaurantId = 9, RestaurantName = "Deeny's", Cuisines = "American", RestaurantAddress = "16246 SE Stark St Portland 97233" },
                     new Restaurant { RestaurantId = 10, RestaurantName = "Don Pedro's", Cuisines = "Mexican", RestaurantAddress = "615 SE 122nd Ave Portland 97233" }

                );

            builder.Entity<User>()
                .HasData(
                    new User { UserId = 1, UserName = "Dom" },
                    new User { UserId = 2, UserName = "Jen" },
                    new User { UserId = 3, UserName = "Anita" },
                    new User { UserId = 4, UserName = "Devin" },
                    new User { UserId = 5, UserName = "Kira" }

                 );

            builder.Entity<Review>()
                .HasData(
                    new Review { ReviewId = 1, UserId = 1, ShopId = 1, Blurb = "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!." },
                    new Review { ReviewId = 2, UserId = 2, ShopId = 2, Blurb = "Perfect donuts. Light and fluffy perfect evenly distributed glaze. I love just a classic glazed donut but had their apple fritter recently and it was heavenly. The coffee goes perfectly with the donuts. Great shop to hang out/work in, decent WiFi, not too loud so it's easy to focus." },
                    new Review { ReviewId = 3, UserId = 3, ShopId = 3, Blurb = "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero" },
                     new Review { ReviewId = 4, UserId = 5, ShopId = 2, Blurb = "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!." },
                    new Review { ReviewId = 5, UserId = 4, ShopId = 2, Blurb = "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!." }

                );
            builder.Entity<ReviewRestaurant>()
           .HasData(
               new ReviewRestaurant { ReviewRestaurantId = 1, UserId = 1, RestaurantId = 1, BlurbRestaurant = "One of my favorite places to dine in Portland.  The staff, especially Fernando, who always remembers us, is extremely friendly and attentive.  I've never had less than an amazing meal here. The atmosphere is beautiful, and they have a great bar area along with outside seating and a large space for a private party." },
               new ReviewRestaurant { ReviewRestaurantId = 2, UserId = 3, RestaurantId = 2, BlurbRestaurant = "We had the best server! I wish I remembered his name. The view is amazing, the food is delicious, the service is great. It is an amazing place to go. I've gone here both dressed up and more casual depending on the occasion. It's such a great place!" },
               new ReviewRestaurant { ReviewRestaurantId = 3, UserId = 4, RestaurantId = 3, BlurbRestaurant = "I've been enjoying the food from this establishment since I was a young boy, and I'm 36yrs old now. Recently revisited them for a to-go order and couldn't be happier with the quality, quantity, or service. Canton Grill, y'all are AWESOME and I plan on being one of your customers as long as I can! Thanks :-)" },
               new ReviewRestaurant { ReviewRestaurantId = 4, UserId = 2, RestaurantId = 3, BlurbRestaurant = "I've been enjoying the food from this establishment since I was a young boy, and I'm 36yrs old now. Recently revisited them for a to-go order and couldn't be happier with the quality, quantity, or service. Canton Grill, y'all are AWESOME and I plan on being one of your customers as long as I can! Thanks :-)" },
               new ReviewRestaurant { ReviewRestaurantId = 5, UserId = 5, RestaurantId = 1, BlurbRestaurant = "One of my favorite places to dine in Portland.  The staff, especially Fernando, who always remembers us, is extremely friendly and attentive.  I've never had less than an amazing meal here. The atmosphere is beautiful, and they have a great bar area along with outside seating and a large space for a private party." }

           );
        }
    }
}