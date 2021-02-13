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
    public class EliminarDocentesModel : PageModel
    {
        private readonly IDocentesRepository _docentesRepository;
        public EliminarDocentesModel(IDocentesRepository docentesRepository)
        {
            _docentesRepository = docentesRepository;
        }
        [BindProperty]
        public Docentes Docentes { get; set; }
        public IActionResult OnGet(int id)
        {
            Docentes = _docentesRepository.GetById(id);
            if (Docentes == null)
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

            var docentesToDelete = _docentesRepository.GetById(id);
            if (docentesToDelete == null)
                return NotFound();
            docentesToDelete.Nombre = Docentes.Nombre;
            docentesToDelete.NIP = Docentes.NIP;
            docentesToDelete.Nivel = Docentes.Nivel;
            docentesToDelete.Activo = Docentes.Activo;
            _docentesRepository.Delete(docentesToDelete);

            return RedirectToPage("./Docentes");
        }
    }
}










