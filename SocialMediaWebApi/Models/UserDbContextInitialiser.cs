using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialMediaWebApi.Models
{
    public class UserDbContextInitialiser : DropCreateDatabaseAlways<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            var users = new List<User>
            {
                 new User { Id=1, Login="First User", AvatarURL="https://avatars.githubusercontent.com/1"}
                ,new User { Id=2, Login="Second User", AvatarURL="https://avatars.githubusercontent.com/2"}
                ,new User { Id=3, Login="Third User", AvatarURL="https://avatars.githubusercontent.com/3"}
                ,new User { Id=4, Login="Fourth User", AvatarURL="https://avatars.githubusercontent.com/4"}
            };

            users.ForEach(u => context.Users.Add(u));

            base.Seed(context);
        }
    }
}