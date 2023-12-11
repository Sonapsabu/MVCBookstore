using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookstore.Models
{
    public class Bookinsert
    {
        [Required(ErrorMessage ="Enter name")]
        public string bookname { get; set; }

        [Required(ErrorMessage = "Enter author")]
        public string author { get; set; }

        
        public string image { get; set; }

        [Required(ErrorMessage = "Enter price")]
        public int price { get; set; }

        public string msg { get; set; }
    }
}