using System.Collections.Generic;
using System.Data.Entity;

namespace SocialMediaWebApi.Models
{
    public class UserDbContextInitialiser : DropCreateDatabaseAlways<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            var users = new List<User>
            {
                 new User { Name="Name1", Login=1, Avatar_Url="https://avatars.githubusercontent.com/1", Location="UK"}
                ,new User { Name="Name2", Login=2, Avatar_Url="https://avatars.githubusercontent.com/2", Location="NI"}
                ,new User { Name="Name3", Login=3, Avatar_Url="https://avatars.githubusercontent.com/3", Location="EU"}
                ,new User { Name="Name4", Login=4, Avatar_Url="https://avatars.githubusercontent.com/4", Location="US"}
            };

            users.ForEach(u => context.Users.Add(u));

            base.Seed(context);
        }
    }
}