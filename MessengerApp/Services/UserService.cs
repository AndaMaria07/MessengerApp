using MessengerApp.Models;
using MessengerApp.Repositories;

namespace MessengerApp.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void Delete(Guid userId)
        {
           _userRepository.Delete(userId);
        }

        public ICollection<User> FindAll()
        {
            return _userRepository.FindAll();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
