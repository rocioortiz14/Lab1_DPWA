using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColegioSystem.Models
{
    public class Materias : EntityBase
    {
        [Required(ErrorMessage = "El Campo Codigo no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El Codigo debe tener Minimo 3 caracteres")]
        [MaxLength(5, ErrorMessage = "El Codigo debe tener Maximo 5 caracteres")]
        [Display(Name = "Codigo Alumno")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Campo de Nombre no puede estar vacio")]
        [MinLength(5, ErrorMessage = "El Nombre debe tener Minimo 10 caracteres")]
        [MaxLength(30, ErrorMessage = "El Nombre debe tener Maximo 30 caracteres")]
        [Display(Name = "Nombre Materia")]
        public string NombreMateria { get; set; }
        public int HorasSemanales { get; set; }
        public string DocenteImparte { get; set; }
        public bool Activa { get; set; }
    }
}

