using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookstore.Models
{
    public class adminregister
    {
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter address")]
        public string Address { get; set; }
        [EmailAddress(ErrorMessage ="enter valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="enter password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="password mismatch")]
        public string confirmpassword { get; set; }
        public string msg { get; set; }
    }
}