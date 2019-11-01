using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [StringLength(255, ErrorMessage = "Your review must be less than 255 characters.")]
        public string Blurb { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 to 5.")]
        public int UserId { get; set; }
        [Required]
        public int ShopId { get; set; }
    
    }
}