using AdventureWebSiteTask.Interfaces;
using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWebSiteTask.Controllers
{
    public class OwnerController : Controller
    {
        AdventureTaskEntities db = new AdventureTaskEntities();
        // GET: Sales

        public ActionResult DashBoard()
        {
            ViewBag.SalesPersonData = (from t in db.PersonLogins

                                     select t).ToList();
                                     
                                    

            return View();
        }
                      
    }
}