using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop.Models
{
    public class User
    {
        [Required]
        [StringLength(36, MinimumLength = 2)]        
        public string Firstname { get; set; }

        [Required]
        [StringLength(36, MinimumLength = 2)]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(36, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [StringLength(36, MinimumLength = 8)]
        public string ConfirmPassword { get; set; }
    }
}