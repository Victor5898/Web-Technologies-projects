using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/jquery/css").Include("~/Content/jquery-ui.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui/js").Include("~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include("~/Scripts/jquery.min.js"));

            bundles.Add(new StyleBundle("~/bundles/toaster/css").Include("~/Content/toastr.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/toaster/js").Include("~/Scripts/toastr.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include("~/Content/DataTables/css/dataTables.bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/datatables/js").Include("~/Scripts/DataTables/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/slick/css").Include("~/Content/Slick/slick.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/slick/js").Include("~/Scripts/Slick/slick.min.js"));

            bundles.Add(new StyleBundle("~/bundles/fancybox/css").Include("~/Content/jquery.fancybox.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/fancybox/js").Include("~/Scripts/jquery.fancybox.pack.js"));

            bundles.Add(new StyleBundle("~/bundles/theme-color/css").Include("~/Content/theme-color/default-theme.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/opensans/css").Include("~/Content/opensans-font.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/fonts/css").Include("~/fonts/line-awesome/css/line-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/style.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/loginStyle/css").Include("~/Content/LoginStyle.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/registerStyle/css").Include("~/Content/registerStyle.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/admin/css").Include("~/Content/admin-style.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/waypoint/js").Include("~/Scripts/waypoints.js"));

            bundles.Add(new ScriptBundle("~/bundles/counterup/js").Include("~/Scripts/jquery.counterup.js"));

            bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include("~/Scripts/jquery.mixitup.js"));

            bundles.Add(new ScriptBundle("~/bundles/pooper/js").Include("~/Scripts/pooper.js"));

            bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include("~/Scripts/custom.js"));
            
        }
    }
}