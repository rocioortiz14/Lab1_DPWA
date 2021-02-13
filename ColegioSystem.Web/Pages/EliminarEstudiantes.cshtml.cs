using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColegioSystem.Data.Interfaces;
using ColegioSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ColegioSystem.Web.Pages
{
    public class EliminarEstudiantesModel : PageModel
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public EliminarEstudiantesModel(IEstudiantesRepository estudiantesRepository)
        {
            _estudiantesRepository = estudiantesRepository;
        }
        [BindProperty]
        public Estudiantes Estudiantes { get; set; }
        public IActionResult OnGet(int id)
        {
            Estudiantes = _estudiantesRepository.GetById(id);
            if (Estudiantes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var estudiantesToDelete = _estudiantesRepository.GetById(id);
            if (estudiantesToDelete == null)
                return NotFound();
            estudiantesToDelete.Nombre = Estudiantes.Nombre;
            estudiantesToDelete.NIE = Estudiantes.NIE;
            estudiantesToDelete.Activo = Estudiantes.Activo;
            _estudiantesRepository.Delete(estudiantesToDelete);

            return RedirectToPage("./Docentes");
        }
    }
}




