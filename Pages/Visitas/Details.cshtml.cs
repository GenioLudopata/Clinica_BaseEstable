using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Visitas
{
    public class DetailsModel : PageModel
    {
        public Visita Visita { get; set; }

        public void OnGet(int id)
        {
            Visita = new Visita { Id = id, Fecha = DateTime.Today, Hora =TimeSpan.Parse("09:00"), Notas = "Detalle ejemplo", Duracion = 40 };
        }
    }
}