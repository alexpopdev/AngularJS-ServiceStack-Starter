using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS_ServiceStack_Starter.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /
        public ActionResult Index()
        {
            ViewBag.Title = "AngularJS ServiceStack Starter application";

            ViewBag.UserName = GetAuthenticatedUserName();
            

            return View();
        }

        public string GetAuthenticatedUserName()
        {
            // check if request is authenticated
            if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.User == null ||
                !System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                throw new Exception("The user is not authenticated.");
            }

            return System.Web.HttpContext.Current.User.Identity.Name;
        }

    }
}
