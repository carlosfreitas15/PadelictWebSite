using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PadelictWebSite.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Palavra-Passe")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        
    }
}