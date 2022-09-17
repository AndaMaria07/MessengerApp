using MessengerApp.Models;

namespace MessengerApp.Services
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(Guid userId);
        void Update(User user);
        ICollection<User> FindAll();
    }
}
