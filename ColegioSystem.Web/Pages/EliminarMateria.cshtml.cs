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
    public class EliminarMateriaModel : PageModel
    {
        private readonly IMateriasRepository _materiasRepository;
        public EliminarMateriaModel(IMateriasRepository materiasRepository)
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

            var materiasToDelete = _materiasRepository.GetById(id);
            if (materiasToDelete == null)
                return NotFound();
            materiasToDelete.Codigo = Materias.Codigo;
            materiasToDelete.NombreMateria = Materias.NombreMateria;
            materiasToDelete.HorasSemanales = Materias.HorasSemanales;
            materiasToDelete.DocenteImparte = Materias.DocenteImparte;
            materiasToDelete.Activa = Materias.Activa;
            _materiasRepository.Delete(materiasToDelete);

            return RedirectToPage("./Materias");
        }
    }
}






