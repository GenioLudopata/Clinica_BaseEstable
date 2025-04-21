using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Terapeutas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Terapeuta TerapeutaEditado { get; set; }

        public IActionResult OnGet(int id)
        {
            TerapeutaEditado = new Terapeuta
            {
                Id = id,
                Nombre = "Lic. Simulado",
                Honorarios = 550,
                Telefono = "5551112222",
                Email = "simulado@clinica.com",
                Licencia = "LIC999"
            };

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Terapeuta {TerapeutaEditado.Nombre} actualizado correctamente.";
            return RedirectToPage("Index");
        }
    }
}