using System.Web;
using System.Web.Optimization;

namespace TMC.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.unobtrusive*",
                        "~/jquery.validate.unobtrusive.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Content/js/lib/angular.js" ));

            bundles.Add(new ScriptBundle("~/bundles/angularapp").Include(
                        "~/Content/js/angular/tmcApp.js",
                        "~/Content/js/angular/Models.js",
                        "~/Content/js/angular/factories.js",
                        "~/Content/js/angular/directives.js",
                        "~/Content/js/angular/controllers.js"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                     "~/Scripts/jquery.flexslider.js",
                     "~/Scripts/jquery-ui.js",
                     "~/Scripts/tmc.common.js",
                     "~/Scripts/tmc.common.city.sayt.js",
                     "~/Scripts/tmc.common.place.sayt.js",
                     "~/Scripts/tmc.common.category.sayt.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/css/modern-business.css",
                      "~/css/flexslider.css",
                      "~/css/jquery-ui.css"));
        }
    }
}
