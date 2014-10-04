using System.Configuration;
using System.Web;
using System.Web.Optimization;

namespace JunaDigitalWebsite
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      var scriptBundle = new ScriptBundle("~/Scripts/bundle").Include(
                                                    "~/Scripts/jquery-{version}.js",
                                                    "~/Scripts/bootstrap.js",
                                                    "~/Scripts/jquery.easing.min.js",
                                                    "~/Scripts/jquery.scrollTo.js",
                                                    "~/Scripts/wow.min.js",
                                                    "~/Scripts/respond.js",
                                                    "~/Scripts/custom.js",
                                                    "~/Scripts/site.js");

      if (ConfigurationManager.AppSettings["Environment"] == "Release")
      {
        scriptBundle.Include("~/Scripts/ga.js");
      }

      bundles.Add(scriptBundle);

      bundles.Add(new StyleBundle("~/Content/css").Include(
                                            "~/Content/bootstrap.css",
                                            "~/Content/font-awesome.css",
                                            "~/Content/animate.css",
                                            "~/Content/style.css",
                                            "~/Content/color.css"));
    }
  }
}
