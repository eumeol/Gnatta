using Autofac;
using Autofac.Integration.Mvc;
using SocialMediaApplication.Application.Data;
using Module = Autofac.Module;

namespace SocialMediaApplication.Application
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register application dependencies
            // i.e. 
            builder.RegisterType<DataRepository>().As<IDataRepository>();
        }

        public static IContainer BuildContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<AutofacModule>();
            return builder.Build();
        }
    }
}