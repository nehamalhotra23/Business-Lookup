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
    public class UsersController : ControllerBase
    {
        private ApplicationDbContext _db;

        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> Get(string userName)
        {
            var query = _db.Users.AsQueryable();

            if (userName != null)
            {
                query = query
                  .Include(s => s.Reviews)
                  .Where(entry => entry.UserName.ToLower().Replace(" ", "") == userName.ToLower().Replace(" ", ""));
            }

            return query.ToList();
        }
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            user.UserId = id;
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var userToDelete = _db.Users.FirstOrDefault(entry => entry.UserId == id);
            _db.Users.Remove(userToDelete);
            _db.SaveChanges();
        }
    }
}