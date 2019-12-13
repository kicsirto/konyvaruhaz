using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace konyvaruhaz.Models
{
    public class Konyv
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A cím megadása kötelező!")]
        [Display(Name = "Cím")]
        public string Cim { get; set; }
        [Required(ErrorMessage = "A szerző megadása kötelező!")]
        [Display(Name = "Szerző")]
        public string Szerzo { get; set; }
        public string Keszlet { get; set; }
        public string Kep { get; set; }
        public string Ar { get; set; }
        public string Kategoria { get; set; }


    }
}