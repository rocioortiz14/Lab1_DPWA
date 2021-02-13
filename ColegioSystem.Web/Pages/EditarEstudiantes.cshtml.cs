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
    public class EditarEstudiantesModel : PageModel
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public EditarEstudiantesModel(IEstudiantesRepository estudiantesRepository)
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

            var estudiantesToUpdate = _estudiantesRepository.GetById(id);
            if (estudiantesToUpdate == null)
                return NotFound();
            estudiantesToUpdate.NIE = Estudiantes.NIE;
            estudiantesToUpdate.Nombre = Estudiantes.Nombre;
            estudiantesToUpdate.Activo = Estudiantes.Activo;

            _estudiantesRepository.Update(estudiantesToUpdate);

            return RedirectToPage("./Estudiantes");
        }
    }
}

