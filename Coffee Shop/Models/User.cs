using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Shop.Models
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}