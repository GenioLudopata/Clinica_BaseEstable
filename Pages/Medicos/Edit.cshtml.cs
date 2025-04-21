using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Medicos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Medico MedicoEditado { get; set; }

        public IActionResult OnGet(int id)
        {
            MedicoEditado = new Medico
            {
                Id = id,
                Nombre = "Dr. Simulado",
                Especialidad = "Fisioterapia",
                Telefono = "5551112222",
                Email = "simulado@example.com"
            };

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Médico {MedicoEditado.Nombre} actualizado correctamente.";
            return RedirectToPage("Index");
        }
    }
}