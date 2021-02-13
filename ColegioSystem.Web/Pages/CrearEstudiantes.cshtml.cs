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
    public class CrearEstudiantesModel : PageModel
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public CrearEstudiantesModel(IEstudiantesRepository estudiantesRepository)
        {
            _estudiantesRepository = estudiantesRepository;
        }
        [BindProperty]
        public Estudiantes Estudiantes { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _estudiantesRepository.Insert(Estudiantes);

            return RedirectToPage("./Estudiantes");
        }
    }
}