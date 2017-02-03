using System.Collections.Generic;

namespace SocialMediaWebApi.Models
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);        
        User Save(User user);
        User Save(int id, User user);
    }
}
