using System.ComponentModel.DataAnnotations;

namespace SocialMediaWebApi.Models
{
    public class User
    {
        [Key]
        public int Login { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Avatar_Url { get; set; }
    }
}