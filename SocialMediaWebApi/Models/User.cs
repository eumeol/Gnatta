using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string AvatarURL { get; set; }
    }
}