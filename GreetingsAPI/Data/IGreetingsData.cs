using GreetingsAPI.Models;

namespace GreetingsAPI.Data
{
    public interface IGreetingsData
    {
        Greeting getGreetingById(int id);
        void update(Greeting greeting);
        void add(Greeting greeting);
        void delete(int id);
        int commit();
    }
}
