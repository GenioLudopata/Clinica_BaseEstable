using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Pacientes
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Paciente PacienteEditado { get; set; }

        public IActionResult OnGet(int id)
        {
            // Simulación de carga desde DB
            PacienteEditado = new Paciente
            {
                Id = id,
                Nombre = "Paciente Ejemplo",
                FechaNacimiento = new DateTime(1995, 1, 1),
                Direccion = "Dirección guardada",
                Telefono = "5550001111"
            };

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            TempData["Mensaje"] = $"Paciente {PacienteEditado.Nombre} actualizado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
