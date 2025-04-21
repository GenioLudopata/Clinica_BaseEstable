using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Tratamientos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Tratamiento TratamientoEditado { get; set; }

        public IActionResult OnGet(int id)
        {
            TratamientoEditado = new Tratamiento
            {
                Id = id,
                Nombre = "Simulado",
                Tipo = "Ejemplo",
                Descripcion = "Modificando tratamiento",
                Costo = 300
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Tratamiento actualizado correctamente.";
            return RedirectToPage("Index");
        }
    }
}