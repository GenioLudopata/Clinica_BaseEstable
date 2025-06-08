using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Pacientes
{
    public class DeleteModel : PageModel
    {
        public Paciente Paciente { get; set; }

        public void OnGet(int id)
        {
            // Simulación de datos
            Paciente = new Paciente
            {
                Id = id,
                Nombre = "juan",
                FechaNacimiento = new DateTime(1985, 3, 10),
                Direccion = "Dirección eliminable",
                Telefono = "5558889999"
            };
        }

        public IActionResult OnPost(int id)
        {
            // Simular eliminación
            TempData["Mensaje"] = $"Paciente con ID {id} eliminado.";
            return RedirectToPage("Index");
        }
    }
}
