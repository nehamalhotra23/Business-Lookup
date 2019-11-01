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
    public class ShopsController : ControllerBase
    {
        private ApplicationDbContext _db;

        public ShopsController(ApplicationDbContext db)
        {
            _db = db;
        }

       
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get(string shopName)
        {
            var query = _db.Shops.AsQueryable();

            if (shopName != null)
            {
                query = query
                  .Include(s => s.Reviews)
                  .Where(entry => entry.ShopName.ToLower().Replace(" ", "") == shopName.ToLower().Replace(" ", ""));
            }

            return query.ToList();
        }
        [HttpPost]
        public void Post([FromBody] Shop shop)
        {
            _db.Shops.Add(shop);
            _db.SaveChanges();

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Shop shop)
        {
            shop.ShopId = id;
            _db.Entry(shop).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
            _db.Shops.Remove(shopToDelete);
            _db.SaveChanges();
        }
    }
}
       