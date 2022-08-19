using Microsoft.EntityFrameworkCore;
using GreetingsAPI.Models;

namespace GreetingsAPI.Data
{
    public class SqlGreetingsData : IGreetingsData
    {
        GreetingsDbContext _context;

        public SqlGreetingsData(GreetingsDbContext context)
        {
            _context = context;
        }

        public void add(Greeting greeting)
        {
            _context.Add(greeting);
        }

        public int commit() 
        {
            return _context.SaveChanges();
        }

        public void delete(int id)
        {
            var greeting = getGreetingById(id);
            if (greeting != null)
            {
                _context.Remove(greeting);
            }
        }

        public Greeting getGreetingById(int id)
        {
            return _context.greetings.Find(id);
        }

        public List<Greeting> getAll()
        {
            return _context.greetings.ToList();
        }

        public void update(Greeting updatedGreeting)
        {
            var entity = _context.greetings.Attach(updatedGreeting);
            entity.State = EntityState.Modified;
        }
    }
}
