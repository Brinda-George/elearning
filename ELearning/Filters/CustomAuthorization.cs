using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;


namespace WebApplication2.Filters
{
    public class CustomAuthentication : FilterAttribute, IAuthenticationFilter
    {

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                //do nothing
            }
            else
            {
                filterContext.Result = new HttpUnauthorizedResult(); // mark unauthorized
            }

        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectToRouteResult("Default",
                    new System.Web.Routing.RouteValueDictionary{
                        {"controller", "Register"},
                        {"action", "Index"},
                        {"returnUrl", filterContext.HttpContext.Request.RawUrl}
                    });
            }
        }
    }
}