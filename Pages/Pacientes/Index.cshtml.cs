using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Pacientes
{
    public class IndexModel : PageModel
    {
        public List<Paciente> ListaPacientes { get; set; }

        public void OnGet()
        {
            // Simulación de datos (base de datos vendrá después)
            ListaPacientes = new List<Paciente>
            {
                new Paciente { Id = 1, Nombre = "Juan Pérez", FechaNacimiento = new DateTime(1990, 1, 1), Direccion = "Calle 123", Telefono = "5551234567" },
                new Paciente { Id = 2, Nombre = "Ana Gómez", FechaNacimiento = new DateTime(1985, 5, 20), Direccion = "Avenida Central", Telefono = "5559876543" }
            };
        }
    }
}
