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
    public class CrearDocenteModel : PageModel
    {
        private readonly IDocentesRepository _docentesRepository;
        public CrearDocenteModel(IDocentesRepository docentesRepository)
        {
            _docentesRepository = docentesRepository;
        }
        [BindProperty]
        public Docentes Docentes { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _docentesRepository.Insert(Docentes);

            return RedirectToPage("./Docentes");
        }
    }
}
    

