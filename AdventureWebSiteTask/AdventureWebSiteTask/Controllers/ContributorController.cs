using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWebSiteTask.Controllers
{
    public class ContributorController : Controller
    {
        AdventureTaskEntities db = new AdventureTaskEntities();
        public ActionResult DashBoard()
        {
            ViewBag.ContributorPersonData = (from t in db.PersonLogins

                                       where t.RoleID == 2 || t.RoleID == 3
                                       select t).ToList();
            

            return View();
        }
    }
}