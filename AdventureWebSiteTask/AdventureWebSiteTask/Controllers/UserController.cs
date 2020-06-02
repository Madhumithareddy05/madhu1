using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWebSiteTask.Controllers
{
    public class UserController : Controller
    {
        AdventureTaskEntities db = new AdventureTaskEntities();
        public ActionResult DashBoard()
        {
            var emailAddress = TempData["EmailAddress"] as string;
            ViewBag.UserPersonData = (from t in db.PersonLogins
                                      where t.EmailAddress == emailAddress
                                      select t).ToList();
            return View();
        }
        
    }
}