using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PadelictWebSite.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "LocalidadeAvalia")]
        [Required]
        public string LocalidadeAvalia { get; set; }

        [Display(Name = "ClubeAvalia")]
        [Required]
        public string ClubeAvalia { get; set; }

        [Display(Name = "TreinadorAvalia")]
        [Required]
        public string TreinadorAvalia { get; set; }

        [Display(Name = "DiaAvalia")]
        [Required]
        public DateTime DiaAvalia { get; set; }

        [Display(Name = "HoraAvalia")]
        [Required]
        public DateTime HoraAvalia { get; set; }

        [Display(Name = "ModoNotifica")]
        [Required]
        public string ModoNotifica { get; set; }

    }
}