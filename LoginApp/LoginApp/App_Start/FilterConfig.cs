using LoginApp.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute
            {
                ExceptionType = typeof(Exception),
                View = "ErrorHandle"
            });
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LoginPostFilter());
        }
    }
}

