using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Equipos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Equipo NuevoEquipo { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            TempData["Mensaje"] = "Equipo registrado correctamente.";
            return RedirectToPage("Index");
        }
    }
}