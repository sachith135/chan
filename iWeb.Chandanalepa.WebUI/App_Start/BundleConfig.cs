using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace iWeb.eCommerce.Deals.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/bootstrap.js"
                        //,
                        //"~Scripts/jquery-1.10.2.intellisense.js",
                        // "~Scripts/jquery-1.10.2.min.map"                       
                        ));



            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            // "~/Scripts/bootstrap.js"
            // ,
            // "~/Scripts/respond.js"
            //   ));

            bundles.Add(new StyleBundle("~/Content/css").Include(                       
                        "~/Content/bootstrap.css",
                        "~/Content/MediaQuery320.css",
                        "~/Content/MediaQuery480.css",
                        "~/Content/MediaQuery768.css",
                        "~/Content/MediaQuery990.css",
                        "~/Content/MediaQuery1200.css",
                         "~/Content/Site.css"
                        )
                        );
        }
    }
}