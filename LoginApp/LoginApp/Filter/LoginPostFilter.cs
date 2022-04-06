using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Filter
{
    public class LoginPostFilter : FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //logging on debug window
            if (HttpContext.Current.Session["Login"] != null)
            {
                Debug.WriteLine("Processing ended at " + DateTime.Now.ToString() + " for " + filterContext.Controller.TempData["userId"]);
                filterContext.Controller.TempData["PostLogin"] = "Processing ended at " + DateTime.Now.ToString() + " for " + filterContext.Controller.TempData["userId"];
                filterContext.Controller.TempData.Keep();
            }
            else
            {
               filterContext.Controller.TempData["PostLogin"] = "Not allowed please LogIn again";
            }

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //logging on debug window
            if (HttpContext.Current.Session["Login"] != null)
            {
                Debug.WriteLine("Login has succesfully happend at " + DateTime.Now.ToString() + " for " + filterContext.Controller.TempData["userId"]);
                filterContext.Controller.TempData["LoginMsg"] = "Login has succesfully happend at " + DateTime.Now.ToString() + " for " + filterContext.Controller.TempData["userId"];
                filterContext.Controller.TempData.Keep();
            }
        }
    }
}