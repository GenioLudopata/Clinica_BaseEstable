using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Medicos
{
    public class IndexModel : PageModel
    {
        public List<Medico> ListaMedicos { get; set; }

        public void OnGet()
        {
            ListaMedicos = new List<Medico>
            {
                new Medico { Id = 1, Nombre = "Dr. Ramírez", Especialidad = "Ortopedia", Telefono = "5551234567", Email = "ramirez@example.com" },
                new Medico { Id = 2, Nombre = "Dra. López", Especialidad = "Rehabilitación", Telefono = "5559876543", Email = "lopez@example.com" }
            };
        }
    }
}









