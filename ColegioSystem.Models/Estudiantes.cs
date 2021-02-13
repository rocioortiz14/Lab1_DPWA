using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColegioSystem.Models
{
    public class Estudiantes : EntityBase
    {
        [Required(ErrorMessage = "El Campo NIE no puede estar vacio")]
        [MinLength(6, ErrorMessage = "El NIE debe tener Minimo 6 caracteres")]
        [MaxLength(8, ErrorMessage = "El NIE debe tener Maximo 8 caracteres")]
        [Display(Name = "NIE Alumno")]
        public string NIE { get; set; }
        [Required(ErrorMessage = "El Campo de Nombre no puede estar vacio")]
        [MinLength(10, ErrorMessage = "El Nombre debe tener Minimo 10 caracteres")]
        [MaxLength(30, ErrorMessage = "El Nombre debe tener Maximo 30 caracteres")]
        [Display(Name = "Nombre Estudiante")]
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
