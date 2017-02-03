using System.Web.Optimization;

namespace SocialMediaApplication.Application.Setup
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").
                Include("~/Content/bootstrap.css",
                        "~/Content/site.css",
                        "~/Scripts/ngToast.css",
                        "~/Scripts/ngToast-animations.css"));

            bundles.Add(new ScriptBundle("~/bundles/library").
                Include("~/Scripts/jquery-3.1.1.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/angular-animate.js",
                        "~/Scripts/angular-sanitize.js",
                        "~/Scripts/ngToast.js"));

            bundles.Add(new ScriptBundle("~/bundles/services").
                Include("~/apps/Modules/ gitService.js",
                      "~/apps/Modules/dbService.js",
                      "~/apps/Modules/localResource.js"));

            bundles.Add(new ScriptBundle("~/bundles/controllers").
                Include("~/apps/Controllers/mainCtrl.js",
                        "~/apps/Controllers/UserEditCtrl.js"));

        }

    }
}