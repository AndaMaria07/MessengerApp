using MessengerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MessengerApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MessengerDBContext _dbContext;

        public UserRepository()
        {
            _dbContext = new MessengerDBContext();
        }

        public void Add(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _dbContext.Remove(_dbContext.Users.Single(a => a.Id == id));
            _dbContext.SaveChanges();
        }

        public ICollection<User> FindAll()
        {
            return _dbContext.Users.ToList();
        }

        public User FindById(Guid id)
        {
            return _dbContext.Users.Find(id);
        }

        public User FindByIdWithData(Guid id)
        {
            return _dbContext.Users.Where(u => u.Id == id).Include(u => u.Messages).ThenInclude(m => m.Receivers).FirstOrDefault();
        }

        public void Update(User entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
