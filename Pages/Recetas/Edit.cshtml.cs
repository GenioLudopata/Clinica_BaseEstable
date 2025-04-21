using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Recetas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Receta RecetaEditada { get; set; }

        public IActionResult OnGet(int id)
        {
            RecetaEditada = new Receta
            {
                Id = id,
                Medicamento = "Simulado",
                Fecha = DateTime.Today,
                Descripcion = "Ejemplo de edición",
                DuracionDias = 7
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Receta actualizada correctamente.";
            return RedirectToPage("Index");
        }
    }
}