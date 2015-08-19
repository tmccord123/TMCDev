namespace TMC.Web
{
    #region Namespaces

    using System.Web.Optimization;

    #endregion

    /// <summary>
    /// The bundle config.
    /// </summary>
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        #region Public Methods and Operators

        /// <summary>
        /// The register bundles method.
        /// </summary>
        /// <param name="bundles">
        /// The bundles object to add to.
        /// </param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            const string jsPathPrefix = "~/Scripts";
            const string cssPathPrefix = "~/Content/themes/";

            bundles.Add(
                new StyleBundle(cssPathPrefix + "base/css").Include(
                    cssPathPrefix + "base/jquery.ui.core.css",
                    cssPathPrefix + "base/jquery.ui.resizable.css",
                    cssPathPrefix + "base/jquery.ui.selectable.css",
                    cssPathPrefix + "base/jquery.ui.accordion.css",
                    cssPathPrefix + "base/jquery.ui.autocomplete.css",
                    cssPathPrefix + "base/jquery.ui.button.css",
                    cssPathPrefix + "base/jquery.ui.dialog.css",
                    cssPathPrefix + "base/jquery.ui.slider.css",
                    cssPathPrefix + "base/jquery.ui.tabs.css",
                    cssPathPrefix + "base/jquery.ui.datepicker.css",
                    cssPathPrefix + "base/jquery.ui.progressbar.css",
                    cssPathPrefix + "base/jquery.mCustomScrollbar.css",
                    cssPathPrefix + "base/jquery.ui.theme.css",
                    cssPathPrefix + "base/jquery-ui.css",
                    cssPathPrefix + "base/ui.dynatree.css",
                    cssPathPrefix + "base/jquery.treeview.css",
                    cssPathPrefix + "base/bootstrap-theme.css",
                    cssPathPrefix + "base/bootstrap.css",
                    cssPathPrefix + "base/bootstrap-combobox.css",
                    cssPathPrefix + "base/bootstrap-multiselect.css",
                    cssPathPrefix + "base/prettify.css",
                    cssPathPrefix + "base/select2.css",
                    cssPathPrefix + "base/select2-bootstrap.css"));
 bundles.Add(
                new StyleBundle( "~/css/").Include(
                    cssPathPrefix + "bootstrap.css"));

            bundles.Add(
                new StyleBundle(cssPathPrefix + "css").Include(
                    cssPathPrefix + "style_jccplan.css",
                    cssPathPrefix + "site.css",
                    cssPathPrefix + "uploadfile.css",
                    cssPathPrefix + "UserInformationDualList.css",
                    cssPathPrefix + "UserInformationGrid.css",
                    cssPathPrefix + "imageUploader.css",
                    cssPathPrefix + "ListView.css",
                    cssPathPrefix + "dynaTreeCommon.css"));

            bundles.Add(
                new ScriptBundle(jsPathPrefix + "/library").Include(
                    jsPathPrefix + "/jquery-2.0.3.js",
                    jsPathPrefix + "/jquery.json-2.3.js",
                    jsPathPrefix + "/jquery-ui-1.10.3.js",
                    // Bootstrap JS for responsive UIs
                    jsPathPrefix + "/bootstrap.js",
                    jsPathPrefix + "/bootstrap-combobox.js",
                    jsPathPrefix + "/bootstrap-multiselect.js",
                    jsPathPrefix + "/prettify.js",
                    jsPathPrefix + "/jquery.carouFredSel-6.2.1-packed.js",
                    jsPathPrefix + "/jquery.mousewheel.js",
                    jsPathPrefix + "/jquery.mCustomScrollbar.js",
                   
                    // used for carausel controls
                  
                    

                    // Jquery validation js
                    // Note : An addition check has been made @ line 827 in jquery.validation.js for checking type of validator
                    // which should not be undefined, the same needs to be done because of using thrid patry tool for file uploader.
                    // In future if this file needs to be change than please take care of that
                    jsPathPrefix + "/jquery.validate.js",
                    jsPathPrefix + "/jquery.unobtrusive*",
                    jsPathPrefix + "/jquery.validate.unobtrusive.js",
                    jsPathPrefix + "/jcc.validate.dynamicContent.js",
                    jsPathPrefix + "/jquery.form.js",
                    jsPathPrefix + "/jquery.uploadfile.js",
                    jsPathPrefix + "/jquery.loader.js",
                    jsPathPrefix + "/jquery-migrate-git.js",
                    // jsPathPrefix + "/jquery.slides.js",

                    // Use the development version of Modernizr to develop with and learn from. Then, when you're
                    // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                    // jsPathPrefix + "/modernizr-*"
                    jsPathPrefix + "/helper-plugins/jquery.ba-throttle-debounce.js",
                    jsPathPrefix + "/helper-plugins/jquery.mousewheel.js",
                    jsPathPrefix + "/helper-plugins/jquery.touchSwipe.js",
                    jsPathPrefix + "/helper-plugins/jquery.transit.js",
                    jsPathPrefix + "/helper-plugins/sayt/select2.js"
                
                    )); 
            
            bundles.Add(
                new ScriptBundle(jsPathPrefix + "/jquery").Include(
                    jsPathPrefix + "/jquery-1.10.2.js" 
                
                    ));
            
            // Creating bundle for js files
            bundles.Add(
                new ScriptBundle(jsPathPrefix + "/jccCommon").Include(
                    jsPathPrefix + "/jcc.common.pubsub.js",
                    jsPathPrefix + "/jcc.common.js",
                    jsPathPrefix + "/jcc.common.utilities.js",
                    jsPathPrefix + "/jcc.common.dataService.js",
                    jsPathPrefix + "/jcc.common.popbox.js",
                    jsPathPrefix + "/jcc.common.dialog.js",
                    jsPathPrefix + "/jcc.common.uploadfile.js",
                    jsPathPrefix + "/jcc.common.imageUploader.js",
                    jsPathPrefix + "/jcc.common.gridview.js",
                    jsPathPrefix + "/jcc.common.dateformat.js",
                    jsPathPrefix + "/jcc.listview.js",
                    jsPathPrefix + "/jquery.dynatree.js",
                    jsPathPrefix + "/jcc.common.dynamicTree.search.js",
                    jsPathPrefix + "/jquery.treeview.js"
                    ));
                        
            // Following bundles are created for testing purpose only.
           /*
            bundles.Add(
                new ScriptBundle("~/bundles/userInformationTree").Include(
                    jsPathPrefix + "/jcc.common.js",
                    jsPathPrefix + "/jquery.dynatree.js",
                    jsPathPrefix + "/jcc.common.dynamicTree.search.js",
                    jsPathPrefix + "/jquery.treeview.js",
                    jsPathPrefix + "/jcc.userInformationTree.js"));
            
           bundles.Add(new ScriptBundle("~/bundles/userInformationGrid").Include(
               jsPathPrefix + "/jcc.common.js",
               jsPathPrefix + "/jquery.loader.js",
               jsPathPrefix + "/jcc.common.gridview.js",
               jsPathPrefix + "/jcc.dataService.js",
               jsPathPrefix + "/jcc.common.popbox.js",
               jsPathPrefix + "/jcc.userInformationGrid.js"));
           

          bundles.Add(new ScriptBundle("~/bundles/commonGrid").Include(
               jsPathPrefix + "/jcc.common.js",
               jsPathPrefix + "/jquery.loader.js",
               jsPathPrefix + "/jcc.common.gridview.js",
               jsPathPrefix + "/jcc.dataService.js",
               jsPathPrefix + "/jcc.common.dateformat.js",
               jsPathPrefix + "/jcc.common.popbox.js"));
            */
        }
        

        #endregion
    }
}