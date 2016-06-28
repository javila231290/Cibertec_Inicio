using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            WriteLog("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            WriteLog("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            WriteLog("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            WriteLog("OnResultExecuting", filterContext.RouteData);
        }

        private void WriteLog(string methodName, RouteData filterContext)
        {            
            Debug.WriteLine($"{methodName} controller: {filterContext.Values["controller"]} action: {filterContext.Values["action"]}", "Action Filter Log");
        }
    }
}
