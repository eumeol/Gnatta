using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
