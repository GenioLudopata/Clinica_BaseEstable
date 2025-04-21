using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Pacientes
{
    public class DetailsModel : PageModel
    {
        public Paciente Paciente { get; set; }

        public void OnGet(int id)
        {
            // Simulación de datos
            Paciente = new Paciente
            {
                Id = id,
                Nombre = "Ejemplo Detalle",
                FechaNacimiento = new DateTime(1988, 8, 8),
                Direccion = "Calle Detalle",
                Telefono = "5551112233"
            };
        }
    }
}
