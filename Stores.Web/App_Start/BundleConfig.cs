using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Stores.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include("~/Bootstrap/bootstrap.js", "~/App/Stores.js"));
            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include("~/Bootstrap/bootstrap.css", "~/App/Stores.css"));
 
            BundleTable.EnableOptimizations = true;
        }
    }
}