using System.Web;
using System.Web.Optimization;

namespace MyResume
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/vendor/jquery/jquery.min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Scripts/resume.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.css",
                      "~/Content/vendor/devicons/css/devicons.min.css",
                      "~/Content/vendor/simple-line-icons/css/simple-line-icons.css",
                      "~/Content/resume.min.css"));
        }
    }
}
