using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Terapeutas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Terapeuta NuevoTerapeuta { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Terapeuta {NuevoTerapeuta.Nombre} registrado correctamente.";
            return RedirectToPage("Index");
        }
    }
}