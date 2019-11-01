using System.Collections.Generic;
namespace Business.Models
{
    public class Shop
    {
        public Shop()
        {
            this.Reviews = new HashSet<Review>();
        }

        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string Type { get; set; }
        public int ShopId { get; set; }
        public  ICollection<Review> Reviews { get; }
    }
}