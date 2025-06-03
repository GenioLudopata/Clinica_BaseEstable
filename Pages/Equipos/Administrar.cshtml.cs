using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Equipos
{
    public class AdministrarModel : PageModel
    {
        public List<Equipo> ListaEquipos { get; set; }

        public void OnGet()
        {
            // Datos simulados (punteros)
            ListaEquipos = new List<Equipo>
            {
                new Equipo { Id = 1, Nombre = "TENS", Descripcion = "Terapia eléctrica", Marca = "MedTech", Modelo = "M1000" },
                new Equipo { Id = 2, Nombre = "Ultrasonido", Descripcion = "Terapia de calor profundo", Marca = "FisioPlus", Modelo = "U200" }
            };
        }
    }
}
