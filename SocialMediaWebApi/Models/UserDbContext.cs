using System.Data.Entity;

namespace SocialMediaWebApi.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}