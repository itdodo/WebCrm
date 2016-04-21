using System.Web.Optimization;

namespace Do.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            //UI
            bundles.Add(new StyleBundle("~/Script/bui/assets/css").Include(
                     "~/Scripts/bui/assets/css/dpl-min.css",
                     "~/Scripts/bui/assets/css/bui.css",
                     "~/Scripts/bui/assets/css/main.css",
                      "~/Content/site.css"
                ));
            //bundles.Add(new ScriptBundle("~/Script/bui/assets/js").Include(
            //        "~/Scripts/bui/jquery-1.8.1.min.js",
            //         "~/Scripts/bui/seed-min.js"
            //    ));

            bundles.Add(new ScriptBundle("~/Script/bui/assets/js").Include(
                 "~/Scripts/bui/assets/js/jquery-1.8.1.min.js",
                 "~/Scripts/bui/assets/js/bui.js",
                 "~/Scripts/bui/assets/js/config.js",
                 "~/Scripts/jquery.nicescroll.js",
                 "~/Scripts/base.js"
            ));
        }
    }
}
