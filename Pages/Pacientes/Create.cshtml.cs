using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Pacientes
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Paciente NuevoPaciente { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Aquí eventualmente guardarás en la base de datos
            // Por ahora solo simula que se guarda
            TempData["Mensaje"] = $"Paciente {NuevoPaciente.Nombre} registrado correctamente.";

            return RedirectToPage("Index");
        }
    }
}
