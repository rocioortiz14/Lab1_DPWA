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
    public class CrearMateriaModel : PageModel
    {
        private readonly IMateriasRepository _materiasRepository;
        public CrearMateriaModel(IMateriasRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }
        [BindProperty]
        public Materias Materias { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _materiasRepository.Insert(Materias);

            return RedirectToPage("./Materias");
        }
    }
}
    

