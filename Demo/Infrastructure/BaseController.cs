using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Common;
using Demo.Pages;
using System.Web.Mvc;
using Demo.Services.Contract;

namespace Demo.Infrastructure
{
    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }

        /// <summary>
        /// Called by the ASP.NET MVC framework before the action method executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                HttpCookie myCookie = HttpContext.Request.Cookies["UserLogin"] as HttpCookie;
                if (myCookie == null)
                {
                    filterContext.Result = new RedirectResult("~/Account/LogIn");
                    return;
                }
                //if (ProjectSession.UserID == null || ProjectSession.UserID == 0)
                //{
                //    filterContext.Result = new RedirectResult("~/Account/LogIn");
                //    return;
                //}
                base.OnActionExecuting(filterContext);
            }
            catch (Exception ex)
            {
                //ErrorLogHelper.Log(ex);
                throw ex;
            }
        }
    }
}