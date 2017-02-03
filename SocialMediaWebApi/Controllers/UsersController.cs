using SocialMediaWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SocialMediaWebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:63517", "*","*")]
    public class UsersController : ApiController
    {
        private IUserRepository uRepository;

        public UsersController()
        {
            uRepository = new UserRepository();
        }

        public UsersController(IUserRepository uRepository)
        {
            this.uRepository = uRepository;

        }

        // GET: api/Users
        public List<User> Get()
        {            
            return uRepository.GetUsers();
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return uRepository.GetUsers()
                .Where(u => u.Login == id)
                .FirstOrDefault();
        }

        // POST: api/Users
        public void Post([FromBody]User user)
        {
            uRepository.Save(user);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]User user)
        {
            uRepository.Save(id, user);

        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
            ;
        }
    }
}
