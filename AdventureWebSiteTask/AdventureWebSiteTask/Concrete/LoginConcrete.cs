using AdventureWebSiteTask.Interfaces;
using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWebSiteTask.Concrete
{
    public class LoginConcrete : ILogin
    {
        public PersonLogin ValidateUser(string userName, string passWord)
        {
            try
            {
                using (var _context = new AdventureTaskEntities())
                {
                    var validate = (from user in _context.PersonLogins
                                    where user.EmailAddress == userName && user.Password == passWord
                                    select user).SingleOrDefault();

                    return validate;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}