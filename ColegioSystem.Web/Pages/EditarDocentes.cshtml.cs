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
    public class EditarDocentesModel : PageModel
    {
        private readonly IDocentesRepository _docentesRepository;
        public EditarDocentesModel(IDocentesRepository docentesRepository)
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
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var docentesToUpdate = _docentesRepository.GetById(id);
            if (docentesToUpdate == null)
                return NotFound();

            docentesToUpdate.Nombre = Docentes.Nombre;
            docentesToUpdate.NIP = Docentes.NIP;
            docentesToUpdate.Nivel = Docentes.Nivel;
            docentesToUpdate.Activo = Docentes.Activo;

            _docentesRepository.Update(docentesToUpdate);

            return RedirectToPage("./Docentes");
        }
    }
}
