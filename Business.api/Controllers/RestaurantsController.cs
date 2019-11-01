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
    public class RestaurantsController : ControllerBase
    {
        private ApplicationDbContext _db;

        public RestaurantsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> Get(string restaurantName)
        {
            var query = _db.Restaurants.AsQueryable();

            if (restaurantName != null)
            {
                query = query
                 
                  .Where(entry => entry.RestaurantName.ToLower().Replace(" ", "") == restaurantName.ToLower().Replace(" ", ""));
            }

            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();

        }
        [HttpPut]
        public void Put(int restaurantId, [FromBody] Restaurant restaurant)
        {
            restaurant.RestaurantId = restaurantId;
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int restaurantId)
        {
            var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == restaurantId);
            _db.Restaurants.Remove(restaurantToDelete);
            _db.SaveChanges();
        }
    }
}       