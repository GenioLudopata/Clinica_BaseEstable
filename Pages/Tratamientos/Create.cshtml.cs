using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Tratamientos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Tratamiento NuevoTratamiento { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Tratamiento registrado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
