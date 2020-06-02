using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWebSiteTask.Interfaces
{
   public interface ILogin
    {
        PersonLogin ValidateUser(string userName, string passWord);
        //bool UpdatePassword(string NewPassword, int UserID);
        //string GetPasswordbyUserID(int UserID);
    }
}
