﻿using System.Web;
using System.Web.Optimization;

namespace PokWarVel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/bootstrap.js",
                      "~/Scripts/js/respond.js",
                      "~/Scripts/js/main.js",
                      "~/Scripts/js/wow.min.js",
                      "~/Scripts/js/lightbox.min.js",
                      "~/Scripts/js/audio.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/css/animate.min.css",
                      "~/Content/css/font-awesome.min.css", 
                      "~/Content/css/lightbox.css",
                      "~/Content/css/main.css",
                      "~/Content/css/responsive.css"));
        }
    }
}
