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
    public class EditarMateriaModel : PageModel
    {
        private readonly IMateriasRepository _materiasRepository;
        public EditarMateriaModel(IMateriasRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }
        [BindProperty]
        public Materias Materias { get; set; }
        public IActionResult OnGet(int id)
        {
           Materias = _materiasRepository.GetById(id);
            if (Materias == null)
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

            var materiasToUpdate = _materiasRepository.GetById(id);
            if (materiasToUpdate == null)
                return NotFound();
            materiasToUpdate.Codigo = Materias.Codigo;
            materiasToUpdate.NombreMateria = Materias.NombreMateria;
            materiasToUpdate.HorasSemanales = Materias.HorasSemanales;
            materiasToUpdate.DocenteImparte = Materias.DocenteImparte;
            materiasToUpdate.Activa = Materias.Activa;
            _materiasRepository.Update(materiasToUpdate);

            return RedirectToPage("./Materias");
        }
    }
}



