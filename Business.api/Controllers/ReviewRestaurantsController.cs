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
                    .Where(reviewRestaurant => reviewRestaurant.RestaurantId == restIdInt);
            }

            if (reviewRestaurantId != null)
            {
                int reviewRestIdint = Int32.Parse(reviewRestaurantId);
                query = query
                    .Where(reviewRestaurant => reviewRestaurant.ReviewRestaurantId == reviewRestIdint);
            }

            return query.ToList();
        }
        [HttpPost]
        public void Post([FromBody] ReviewRestaurant reviewRestaurant)
        {
            _db.ReviewRestaurants.Add(reviewRestaurant);
            _db.SaveChanges();

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReviewRestaurant reviewRestaurant)
        {
            reviewRestaurant.ReviewRestaurantId = id;
            _db.Entry(reviewRestaurant).State = EntityState.Modified;
            _db.SaveChanges();

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var restreviewToDelete = _db.ReviewRestaurants.FirstOrDefault(entry => entry.ReviewRestaurantId == id);
            _db.ReviewRestaurants.Remove(restreviewToDelete);
            _db.SaveChanges();
        }
    }
}
