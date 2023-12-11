using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookstore.Models
{
    public class adminlogin
    {
        [Required(ErrorMessage ="enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="enter password")]
        public string Password { get; set; }
        public string msg { get; set; }

    }
}