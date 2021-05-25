using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Enums;
using eUseControl.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.Web.ActionFilter
{
    public class UserModAttribute: ActionFilterAttribute
    {
        private readonly ISession _session;

        public UserModAttribute()
        {
            BussinesLogic bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie CookieApi = HttpContext.Current.Request.Cookies["X-KEY"];
            if (CookieApi != null)
            {
                var userByCookie = _session.GetUserByCookie(CookieApi.Value);
                if (userByCookie != null)
                {
                    HttpContext.Current.SetMySessionObject(userByCookie);
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                }
            }
        }
    }
}