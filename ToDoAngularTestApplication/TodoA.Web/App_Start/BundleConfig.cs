using System.Web.Optimization;

namespace TodoA.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Scripts

            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/third-party").Include(
                        "~/Scripts/angular/angular.js",
                        "~/Scripts/angular/angular-route.js",
                        "~/Scripts/moment.js"
                        
            ));

            bundles.Add(new ScriptBundle("~/bundles/angular-app").Include(
                        // the main application/module script
                        "~/Scripts/app/TodoApp.js",

                        // services
                        "~/Scripts/app/services/*.js",

                        // factories
                        "~/Scripts/app/factories/*.js",

                        // contorllers
                        "~/Scripts/app/controllers/*.js",

                        // Routing
                        "~/Scripts/app/routing/*.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            #endregion

            #region Content

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css",
                      "~/Content/app/app.css"
                    ));

            #endregion
        }
    }
}
