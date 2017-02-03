using System.Collections.Generic;
using System.Linq;

namespace SocialMediaWebApi.Models
{
    public class UserRepository : IUserRepository
    {
        UserDbContext _userDbContext = new UserDbContext();

        public List<User> GetUsers()
        {
            return _userDbContext.Users.ToList();
        }

        public User GetUser(int id)
        {
            return new User { Login=88};
        }

        public User Save(User user)
        {
            _userDbContext.Users.Add(user);

            _userDbContext.SaveChanges();

            return user;
        }

        public User Save(int id, User user)
        {
            return user;
        }
    }
}