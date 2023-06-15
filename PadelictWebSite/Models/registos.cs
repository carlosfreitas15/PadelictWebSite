using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PadelictWebSite.Models
{
    public class registos
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Email")]
        
        public string Email { get; set; }

        [Display(Name = "Palavra-Passe")]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }

        [Display(Name = "NomeClube")]
        
        public string NomeClube { get; set; }

        [Display(Name = "Nome")]
        
        public string Nome { get; set; }

        [Display(Name = "Apelido")]
        
        public string Apelido { get; set; }

        [Display(Name = "Localidade")]
        
        public string Localidade { get; set; }

        [Display(Name = "Contacto")]
        
        public int Contacto { get; set; }

        [Display(Name = "DataNascimento")]
        
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Altura")]
        
        public double Altura { get; set; }

        [Display(Name = "Peso")]
        
        public double Peso { get; set; }

        [Display(Name = "Treinadordesde")]
        
        public DateTime Treinadordesde { get; set; }

        [Display(Name = "Licenca")]
        
        public int Licenca { get; set; }

        [Display(Name = "MaoPref")]
        
        public string MaoPref { get; set; }

        [Display(Name = "LadoPref")]
        
        public string LadoPref { get; set; }

        [Display(Name = "TopPancada")]
        
        public string TopPancada { get; set; }

        [Display(Name = "TipoJogo")]
        
        public string TipoJogo { get; set; }

        [Display(Name = "Raquete")]
        
        public string Raquete { get; set; }

        [Display(Name = "Experiencia")]
        
        public DateTime Experiencia { get; set; }

        [Display(Name = "Frequencia")]
        
        public string Frequencia { get; set; }

        [Display(Name = "ZonaAcao")]
        
        public string ZonaAcao { get; set; }

        [Display(Name = "ClubePref")]
        
        public string ClubePref { get; set; }

        [Display(Name = "DiaPref")]
        
        public string DiaPref { get; set; }

        [Display(Name = "HoraPref")]
        
        public DateTime HoraPref { get; set; }

        [Display(Name = "NumCourts")]
        
        public int NumCourts { get; set; }

        [Display(Name = "NumTreinadores")]
        
        public int NumTreinadores { get; set; }

        [Display(Name = "NumAlunos")]
        
        public int NumAlunos { get; set; }





       
     
            

            

            
        
            
           
            

            

         
        
            

            

            

            

            

            

      

            

            

            

        
        
    }
}