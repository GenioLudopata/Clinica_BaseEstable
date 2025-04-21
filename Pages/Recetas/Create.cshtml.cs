using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Recetas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Receta NuevaReceta { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Receta registrada correctamente.";
            return RedirectToPage("Index");
        }
    }
}