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
    public class ReviewsController : ControllerBase
    {
        private ApplicationDbContext _db;

        public ReviewsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string shopId, String reviewId)
        {
            var query = _db.Reviews.AsQueryable();

            if (shopId != null)
            {
                int shopIdInt = Int32.Parse(shopId);
                query = query
                    .Where(review => review.ShopId == shopIdInt);
            }

            if (reviewId != null)
            {
                int reviewIdint = Int32.Parse(reviewId);
                query = query
                    .Where(review => review.ReviewId == reviewIdint);
            }

            return query.ToList();
        }
    }
}