
namespace TMC.Web.Shared
{
    #region Namespaces

    using System;
    using System.Net;
    using System.Web.Mvc;
    using TMC.Shared;
    using TMC.Web.ViewModels;

    #endregion

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public sealed class JCCExceptionHandlerAttribute : HandleErrorAttribute
    {
        #region "Constants"

        private const string ErrorController = "Error";
        private const string ErrorControllerAction = "Index";

        #endregion

        #region CTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="JCCExceptionHandlerAttribute"/> class.
        /// </summary>
        public JCCExceptionHandlerAttribute()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Called when an exception occurs.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext != null && filterContext.Exception != null)
            {
                //Call exception handler for logging the exception
                ExceptionManager.HandleException(filterContext.Exception);

                // Handling HTTP & Ajax requests.
                filterContext.ExceptionHandled = true;

                if (!filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    // storing errormessage and stacktrace
                    SessionStateManager<ErrorState>.Data.ErrorMessage = filterContext.Exception.Message;
                    SessionStateManager<ErrorState>.Data.StackTrace = filterContext.Exception.StackTrace;

                    // preparing redirect url
                    Controller controller = (Controller)filterContext.Controller;
                    string redirectUrl = controller.Url.SmartAction(ErrorControllerAction, ErrorController);

                    filterContext.Result = new RedirectResult(redirectUrl);
                }
                else
                {
                    filterContext.Result = OperationResult<bool>.CreateErrorResult(
                                           filterContext.Exception.Message,
                                           filterContext.Exception.StackTrace).ToJsonResult();
                }
            }
        }

        #endregion
    }
}