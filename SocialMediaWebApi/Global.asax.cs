using SocialMediaWebApi.Models;
using System.Data.Entity;
using System.Web.Http;

namespace SocialMediaWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new UserDbContextInitialiser());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
