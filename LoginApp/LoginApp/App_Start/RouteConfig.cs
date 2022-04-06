using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;


namespace LoginApp
{
    public class RouteConfig
    {
       public static Boolean checkSessionLogin()
        {
            try
            {
                if (HttpContext.Current.Session["Login"] != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
           
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "Demo/Login",
               defaults: new { controller = "Demo", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "PostLogin",
            url: "Demo/PostLogin",
            defaults: new { controller = "Demo", action = "PostLogin", id = UrlParameter.Optional },
            constraints: checkSessionLogin()
           );

         routes.MapRoute(
         name: "validate",
         url: "Demo/validate",
        defaults: new { controller = "Demo", action = "validate", id = UrlParameter.Optional }
         
        );


        }
    }
}
