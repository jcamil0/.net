using System.Web;
using System.Web.Optimization;

namespace VotacionWeb
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

        
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new StyleBundle("~/Content/PluginsCSS").Include(

                 
                   "~/Content/Plugins/fontawesome-free-5.15.2/css/all.min.css",

                  
                   "~/Content/Plugins/sweetalert2/css/sweetalert.css"

                   ));

            bundles.Add(new StyleBundle("~/Content/PluginsJS").Include(

                    
                    "~/Content/Plugins/fontawesome-free-5.15.2/js/all.min.js",

                   
                   "~/Content/Plugins/sweetalert2/js/sweetalert.js",

                  
                   "~/Content/Plugins/jquery-loading-overlay/loadingoverlay.min.js",


                   "~/Scripts/jquery.validate.min.js"
                    ));

        }
    }
}
