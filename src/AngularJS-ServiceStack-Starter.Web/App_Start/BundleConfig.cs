using System;
using System.Configuration;
using System.Web.Optimization;

namespace AngularJS_ServiceStack_Starter.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/legacy-browsers").Include(
                        "~/Scripts/modernizr-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/basejs").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/i18n/angular-locale_en-gb.js",
                        "~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularui").Include(
                       "~/Scripts/ui-bootstrap-{version}.js",
                       "~/Scripts/ui-bootstrap-tpls-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/app.js",
                //"~/Scripts/app/filters/*.js",
                //"~/Scripts/app/directives/*.js",
                "~/Scripts/app/services/*.js",
                "~/Scripts/app/controllers/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/sitecss").Include(
                "~/Content/app/site.css"));


#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif

        }
    }
}