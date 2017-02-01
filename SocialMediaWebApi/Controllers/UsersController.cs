using SocialMediaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialMediaWebApi.Controllers
{
    public class UsersController : ApiController
    {
        UserRepository uRepository = new UserRepository();

        // GET: api/Users
        public IEnumerable<User> Get()
        {            
            return uRepository.GetUsers();
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return uRepository.GetUsers()
                .Where(u => u.Id == id)
                .FirstOrDefault();
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
