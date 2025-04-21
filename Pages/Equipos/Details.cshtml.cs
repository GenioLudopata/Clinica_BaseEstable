using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Equipos
{
    public class DetailsModel : PageModel
    {
        public Equipo Equipo { get; set; }

        public void OnGet(int id)
        {
            Equipo = new Equipo { Id = id, Nombre = "Ejemplo", Descripcion = "Ver detalles del equipo", Marca = "DemoBrand", Modelo = "DEMO-1" };
        }
    }
}
