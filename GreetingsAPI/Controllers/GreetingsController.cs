using GreetingsAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GreetingsAPI.Data;
using GreetingsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GreetingsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class GreetingsController : ControllerBase
    {
        private readonly GreetingsDbContext _context;

        public GreetingsController(GreetingsDbContext context)
        {
            _context = context;
        }

        // Create/Update
        [HttpPost]
        public JsonResult CreateEdit(Greeting greeting)
        {
            if (greeting.id == 0)
            {
                _context.Add(greeting);
            } else
            {
                var existingGreeting = _context.greetings.Find(greeting.id);
                if (existingGreeting == null)
                {
                    return new JsonResult(NotFound());
                }
                existingGreeting = greeting;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(greeting));
        }

        // Get
        [HttpGet]
        public JsonResult get(int id)
        {
            var result = _context.greetings.Find(id);
            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            _context.SaveChanges();
            return new JsonResult(Ok(result));
        }

        // Get all
        [HttpGet]
        public JsonResult getAll()
        {
            var result = _context.greetings.ToList();
            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            _context.SaveChanges();
            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult delete(int id)
        {
            var result = _context.greetings.Find(id);
            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            _context.greetings.Remove(result);
            _context.SaveChanges();
            return new JsonResult(Ok(result));
        }

    }
}
