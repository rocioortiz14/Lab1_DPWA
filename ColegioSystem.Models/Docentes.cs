using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColegioSystem.Models
{
 public  class Docentes :EntityBase
    {
        [Required(ErrorMessage ="El Campo Nombre no puede estar vacio")]
        [MinLength(10, ErrorMessage = "El Nombre debe tener Minimo 10 caracteres")]
        [MaxLength(30, ErrorMessage = "El Nombre debe tener Maximo 30 caracteres")]
        [Display(Name = "Nombre del Docente")]
        public string  Nombre { get; set; }
        [Required(ErrorMessage ="El Campo de NIP no puede estar vacio")]
        [MinLength(6, ErrorMessage = "El NIP debe tener Minimo 6 caracteres")]
        [MaxLength(8, ErrorMessage = "El NIP debe tener Maximo 8 caracteres")]
        [Display(Name = "Numero Profesional")]
        public string  NIP { get; set; }

        public int Nivel { get; set; }

        public bool Activo { get; set; }
    }
       

      
}
