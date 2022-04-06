using LoginApp.Filter;
using LoginApp.Models;
using System;
using System.Diagnostics;
using System.Web.Mvc;


namespace LoginApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpPost]
        public ActionResult validate(string uid)
        {
            
            if(uid.Length==0)
            {
                return Json(new { iSvalid = true, message = "valid User" }, JsonRequestBehavior.AllowGet);
            }

            if (uid.Substring(0,3)=="EMP" && uid.Substring(3).Length==5)
            {
                try
                {
                    int n = int.Parse(uid.Substring(3));
                   
                }
                catch(Exception e)
                {
                  
                    return Json(new { iSvalid = false, message = "user id is not valid format !" }, JsonRequestBehavior.AllowGet);
                }
            }
             ;
            return Json(new { iSvalid = true, message = "valid User" }, JsonRequestBehavior.AllowGet);



        }
        
        public ActionResult Login()
        {
           
            return View(new Login());
        }
        [HttpPost]
        public ActionResult Login(Login user)
        {
           
            if(user.userId=="EMP84556" && user.password=="user")
            {
                this.HttpContext.Session.Add("Login", true);
                this.HttpContext.Session.Timeout=1;
                
                
                TempData["successMsg"] = "You Have Succesfully Logged In !";
                TempData["userId"]=user.userId;
                
                return RedirectToAction("PostLogin");
            }
            ViewBag.error("Invalid User");
             return RedirectToAction("Login");
        }
        [LoginPostFilter]//for logging in debug screen
        public ActionResult PostLogin()
        {
            return View();
        }


    }
}