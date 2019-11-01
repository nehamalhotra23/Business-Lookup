using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Business.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Business.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewRestaurantsController : ControllerBase
    {
        private ApplicationDbContext _db;

        public ReviewRestaurantsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReviewRestaurant>> Get(string restaurantId, String reviewRestaurantId)
        {
            var query = _db.ReviewRestaurants.AsQueryable();

            if (restaurantId != null)
            {
                int restIdInt = Int32.Parse(restaurantId);
                query = query
                    .Where(reviewRest => reviewRest.RestaurantId == restIdInt);
            }

            if (restaurantId != null)
            {
                int reviewRestIdint = Int32.Parse(restaurantId);
                query = query
                    .Where(reviewRest => reviewRest.ReviewRestaurantId == reviewRestIdint);
            }

            return query.ToList();
        }
    }
}    
