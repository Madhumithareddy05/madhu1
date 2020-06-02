using AdventureWebSiteTask.Interfaces;
using AdventureWebSiteTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWebSiteTask.Concrete
{
    public class RolesConcrete : IRole
    {

        /// <summary>
        /// Get RoleID Name by RoleName
        /// </summary>
        /// <param name="Rolename"></param>
        /// <returns></returns>
        public int getRolesofUserbyRolename(string Rolename)
        {
            using (var _context = new AdventureTaskEntities())
            {
                var roleID = (from role in _context.Roles
                              where role.RoleName== Rolename
                              select role.RoleID).SingleOrDefault();

                return roleID;
            }
        }
    }
}