using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdventureWebSiteTask.Models.Data
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username Required")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
    }
}