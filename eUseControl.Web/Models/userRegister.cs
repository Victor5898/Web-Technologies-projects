using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class userRegister
    {
        [Display(Name = "Prenumele")]
        public string FirstName { get; set; }

        [Display(Name = "Numele")]
        public string LastName { get; set; }
        public string Username { get; set; }

        [Display(Name = "Email-ul tau")]
        public string Email { get; set; }

        [Display(Name = "Parola")]
        public string Password { get; set; }   
        public bool Terms { get; set; }

        [Display(Name = "Confirmare parola")]
        public string Confirm { get; set; }
    }
}