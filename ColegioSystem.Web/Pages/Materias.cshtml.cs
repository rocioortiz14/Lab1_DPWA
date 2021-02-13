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
    public class MateriasModel : PageModel
    {
        private readonly IMateriasRepository _materiasRepository;

        public MateriasModel(IMateriasRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }
        [BindProperty]
        public IEnumerable<Materias> Materias { get; set; }
        public IActionResult OnGet()
        {

           Materias = _materiasRepository.List();
            return Page();
        }
    }
}


