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
        public ActionResult<IEnumerable<Shop>> Get()
        {
            var query = _db.Shops.AsQueryable();

            // if (shopName != null)
            // {
            //     query = query
            //       .Include(s => s.Reviews)
            //       .Where(entry => entry.ShopName.ToLower().Replace(" ", "") == shopName.ToLower().Replace(" ", ""));
            // }

            return query.ToList();
        }
    }
}
       