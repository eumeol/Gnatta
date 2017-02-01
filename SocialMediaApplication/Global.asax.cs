using Autofac;
using Autofac.Integration.Mvc;
using SocialMediaApplication.Application;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SocialMediaApplication.Application.Setup;

namespace SocialMediaApplication
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IContainer container = AutofacModule.BuildContainer();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}