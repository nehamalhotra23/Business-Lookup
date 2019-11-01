using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class ReviewRestaurant
    {
        public int ReviewRestaurantId { get; set; }
        [StringLength(255, ErrorMessage = "Your review must be less than 255 characters.")]
        public string BlurbRestaurant { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RestaurantId { get; set; }

    }
}