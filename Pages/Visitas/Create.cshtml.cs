using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Visitas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Visita NuevaVisita { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            TempData["Mensaje"] = "Visita registrada correctamente.";
            return RedirectToPage("Index");
        }
    }
}