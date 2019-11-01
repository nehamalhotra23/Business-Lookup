using System.Collections.Generic;
namespace Business.Models
{
    public class Restaurant
    {
        // public double Rating {get; set;}
        public Restaurant()
        {
            this.Reviews = new HashSet<Review>();
        }

        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantAddress { get; set; }

        public ICollection<Review> Reviews { get; }
    }
}