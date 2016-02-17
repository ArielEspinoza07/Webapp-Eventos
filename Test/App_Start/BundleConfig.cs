using System.Web;
using System.Web.Optimization;

namespace Test
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                        "~/Scripts/plugins/morris/morris-data.js",
                        "~/Scripts/plugins/morris/morris.js",
                        "~/Scripts/plugins/morris/raphael.js",
                        "~/Scripts/plugins/morris/morris.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/flot").Include(
                        "~/Scripts/plugins/flot/excanvas.js",
                        "~/Scripts/plugins/flot/flot-data.js",
                        "~/Scripts/plugins/flot/jquery.flot.js",
                        "~/Scripts/plugins/flot/jquery.flot.pie.js",
                        "~/Scripts/plugins/flot/jquery.flot.resize.js",
                        "~/Scripts/plugins/flot/jquery.flot.tooltip.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/sb").Include(
                        "~/Content/sb-admin.css"));

            bundles.Add(new StyleBundle("~/Content/morris").Include(
                        "~/Content/plugins/morris.css"));

            bundles.Add(new StyleBundle("~/font-awesome/font").Include(
                        "~/font-awesome/css/font-awesome.min.css",
                        "~/font-awesome/css/font-awesome.css"));

            

            
        }
    }
}