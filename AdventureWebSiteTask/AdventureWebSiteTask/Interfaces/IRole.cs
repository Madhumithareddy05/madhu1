using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWebSiteTask.Interfaces
{
   public interface IRole
    {
        int getRolesofUserbyRolename(string Rolename);
    }
}
