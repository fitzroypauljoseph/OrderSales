using System.Web;
using System.Web.Optimization;

namespace Kidly.Interview.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/script.js"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                      "~/Styles/styles.css"));
        }
    }
}
