using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Medicos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Medico NuevoMedico { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Médico {NuevoMedico.Nombre} registrado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
