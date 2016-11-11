using System.Web;
using System.Web.Optimization;

namespace redeSocial
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/css/css").Include(
                                                                "~/css/home.css",
                                                                "~/css/conquistas.css",
                                                                "~/css/perfil.css",
                                                                "~/css/ranking.css",
                                                                "~/css/paginas.css",
                                                                "~/css/login.css",
                                                                "~/css/feed.css",
                                                                "~/css/duelos.css"
                                                            ));

            //bundles.Add(new StyleBundle("~/css/themes/base/css").Include(
            //            "~/css/themes/base/jquery.ui.core.css",
            //            "~/css/themes/base/jquery.ui.resizable.css",
            //            "~/css/themes/base/jquery.ui.selectable.css",
            //            "~/css/themes/base/jquery.ui.accordion.css",
            //            "~/css/themes/base/jquery.ui.autocomplete.css",
            //            "~/css/themes/base/jquery.ui.button.css",
            //            "~/css/themes/base/jquery.ui.dialog.css",
            //            "~/css/themes/base/jquery.ui.slider.css",
            //            "~/css/themes/base/jquery.ui.tabs.css",
            //            "~/css/themes/base/jquery.ui.datepicker.css",
            //            "~/css/themes/base/jquery.ui.progressbar.css",
            //            "~/css/themes/base/jquery.ui.theme.css"));
        }
    }
}