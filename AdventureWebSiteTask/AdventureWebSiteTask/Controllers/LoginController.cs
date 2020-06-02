using AdventureWebSiteTask.Concrete;
using AdventureWebSiteTask.Interfaces;
using AdventureWebSiteTask.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWebSiteTask.Controllers
{
    public class LoginController : Controller
    {
        private ILogin _ILogin;
        
        public LoginController()
        {
            _ILogin = new LoginConcrete();
           
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(loginViewModel.EmailAddress) && !string.IsNullOrEmpty(loginViewModel.Password))
                {
                    var username = loginViewModel.EmailAddress;
                    TempData["EmailAddress"] = loginViewModel.EmailAddress;
                    var password = loginViewModel.Password;

                    var result = _ILogin.ValidateUser(username, password);


                    if (result != null)
                    {
                        if (result.BusinessEntityID == 0 || result.BusinessEntityID < 0)
                        {
                            ViewBag.errormessage = "Entered Invalid Username and Password";
                        }
                        else
                        {
                         
                            var RoleID = result.RoleID;
                          

                            

                            if (RoleID == 1)
                            {
                                
                                return RedirectToAction("DashBoard", "Owner");
                            }
                            else if (RoleID == 2)
                            {


                                



                                return RedirectToAction("DashBoard", "Contributor");
                            }
                            else if (RoleID == 3)
                            {
                              

                                return RedirectToAction("DashBoard", "User" );
                            }

                        }
                    }
                    else
                    {
                        ViewBag.errormessage = "Entered Invalid Username and Password";
                        return View(loginViewModel);
                    }
                }

                    return View(loginViewModel);
                }
            catch (Exception)
            {
                throw;
            }

        }
    }
}