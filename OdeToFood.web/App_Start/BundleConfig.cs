using System.Web;
using System.Web.Optimization;

namespace OdeToFood.web
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/mybundle").Include(
            //   "~/Resources/Core/Javascripts/jquery-1.7.1.min.js",
            //   "~/Resources/Core/Javascripts/jquery-ui-1.8.16.min.js",
            //   "~/Resources/Core/Javascripts/jquery.validate.min.js",
            //   "~/Resources/Core/Javascripts/jquery.validate.unobtrusive.min.js",
            //   "~/Resources/Core/Javascripts/jquery.unobtrusive-ajax.min.js",
            //   "~/Resources/Core/Javascripts/jquery-ui-timepicker-addon.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
