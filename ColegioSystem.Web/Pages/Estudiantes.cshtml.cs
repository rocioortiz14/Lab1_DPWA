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
    public class EstudiantesModel : PageModel
    {

        private readonly IEstudiantesRepository _estudiantesRepository;

        public EstudiantesModel(IEstudiantesRepository estudiantesRepository)
        {
            _estudiantesRepository = estudiantesRepository;
        }
        [BindProperty]
        public IEnumerable<Estudiantes> Estudiantes { get; set; }
        public IActionResult OnGet()
        {

            Estudiantes = _estudiantesRepository.List();
            return Page();
        }
    }
}
