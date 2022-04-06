using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace LoginApp
{
    public class RouteConstraintSession : IRouteConstraint
    {
        public  bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            try
            {
                if (httpContext.Session["Login"].Equals(true))
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}