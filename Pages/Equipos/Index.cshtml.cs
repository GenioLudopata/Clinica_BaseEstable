using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        public List<Equipo> ListaEquipos { get; set; } = new();

        public void OnGet()
        {
            ListaEquipos = new List<Equipo>
            {
                new Equipo { Id = 1, Nombre = "Ultrasonido", Descripcion = "Equipo de ultrasonido terapéutico", Marca = "TherapyX", Modelo = "TX-2000" },
                new Equipo { Id = 2, Nombre = "Electroestimulador", Descripcion = "Estimulación muscular eléctrica", Marca = "ElectroMed", Modelo = "EM-100" }
            };
        }
    }
}

