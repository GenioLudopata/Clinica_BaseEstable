using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Terapeutas
{
    public class IndexModel : PageModel
    {
        public List<Terapeuta> ListaTerapeutas { get; set; }

        public void OnGet()
        {
            ListaTerapeutas = new List<Terapeuta>
            {
                new Terapeuta { Id = 1, Nombre = "Lic. Sánchez", Honorarios = 500, Telefono = "5551234567", Email = "sanchez@clinica.com", Licencia = "LIC123" },
                new Terapeuta { Id = 2, Nombre = "Lic. Torres", Honorarios = 600, Telefono = "5559876543", Email = "torres@clinica.com", Licencia = "LIC456" }
            };
        }
    }
}










