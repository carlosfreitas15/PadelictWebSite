using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PadelictWebSite.Models
{
    public class Concelhos
    {
        [Key]
        public int IdConcelhos { get; set; }

        [Display(Name = "NomeConcelhos")]
        [Required]
        public string NomeConcelhos { get; set; }
    }
}