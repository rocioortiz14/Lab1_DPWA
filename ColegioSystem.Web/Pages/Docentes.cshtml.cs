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
    public class DocentesModel : PageModel
    {
        private readonly IDocentesRepository _docentesRepository;

        public DocentesModel(IDocentesRepository docentesRepository)
        {
            _docentesRepository = docentesRepository;
        }
        [BindProperty]
        public IEnumerable<Docentes> Docentes { get; set; }
        public IActionResult OnGet()
        {
          
            Docentes = _docentesRepository.List();
            return Page();
        }
    }
}
