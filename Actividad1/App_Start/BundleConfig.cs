using System.Web;
using System.Web.Optimization;

namespace Actividad1
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Cargamos todos los estilos del template
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/estilos/bootstrap.min.css",
                      "~/Content/estilos/font-awesome.min.css",
                      "~/Content/estilos/animate.min.css",
                      "~/Content/estilos/et-line-font.css",
                      "~/Content/estilos/nivo-lightbox.css",
                      "~/Content/estilos/nivo_themes/default/default.css",
                      "~/Content/estilos/style.css"));

            // Cargamos todos los scripts
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/smoothscroll.js",
                      "~/Scripts/isotope.js",
                      "~/Scripts/imagesloaded.min.js",
                      "~/Scripts/nivo-lightbox.min.js",
                      "~/Scripts/jquery.backstretch.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/custom.js"));
        }
    }
}
