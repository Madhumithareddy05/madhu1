using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWebSiteTask.Models.Data
{
    public class PersonViewModel
    {
        public int BusinessEntityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> RoleID { get; set; }
    }
}