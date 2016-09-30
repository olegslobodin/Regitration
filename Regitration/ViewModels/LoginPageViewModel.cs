using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Regitration.ViewModels
{
    public class LoginPageViewModel
    {
        [Required(ErrorMessage = "The field 'Email' is required!")]
        [Display(Name = "Login:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field 'Password' is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }
}