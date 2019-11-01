using System.Collections.Generic;
namespace Business.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            this.ReviewRestaurants = new HashSet<ReviewRestaurant>();
        }

        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantAddress { get; set; }

        public ICollection<ReviewRestaurant> ReviewRestaurants { get; }
    }
}