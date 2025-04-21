using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Visitas
{
    public class IndexModel : PageModel
    {
        public List<Visita> ListaVisitas { get; set; } = new();

        public void OnGet()
        {
            ListaVisitas = new List<Visita>
            {
                new Visita { Id = 1, Fecha = DateTime.Today, Hora = TimeSpan.Parse("10:00"), Notas = "Primera sesión", Duracion = 60 },
                new Visita { Id = 2, Fecha = DateTime.Today.AddDays(1), Hora = TimeSpan.Parse("11:00"), Notas = "Seguimiento", Duracion = 45 }
            };
        }
    }
}

