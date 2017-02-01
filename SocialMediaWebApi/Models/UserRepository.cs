using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            throw new NotImplementedException();
        }

        public User Save(User user)
        {
            throw new NotImplementedException();
        }

        public User Save(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}