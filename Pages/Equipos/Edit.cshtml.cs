using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Equipos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Equipo EquipoEditado { get; set; }

        public IActionResult OnGet(int id)
        {
            EquipoEditado = new Equipo { Id = id, Nombre = "Simulado", Descripcion = "Demo", Marca = "MarcaX", Modelo = "ModelY" };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            TempData["Mensaje"] = "Equipo actualizado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
