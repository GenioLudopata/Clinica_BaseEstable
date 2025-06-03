using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Tratamientos
{
    public class AdministrarModel : PageModel
    {
        public List<Tratamiento> ListaTratamientos { get; set; }

        public void OnGet()
        {
            // Datos simulados
            ListaTratamientos = new List<Tratamiento>
            {
                new Tratamiento
                {
                    Id = 1,
                    Nombre = "Rehabilitación de rodilla",
                    Tipo = "Fisioterapia",
                    Descripcion = "Ejercicios recuperación postoperatoria.",
                    Costo = 750.00m,
                    Equipo = new Equipo { Nombre = "Bicicleta estacionaria" }
                },
                new Tratamiento
                {
                    Id = 2,
                    Nombre = "Terapia con ultrasonido",
                    Tipo = "Electroterapia",
                    Descripcion = "Ondas para tejidos profundos.",
                    Costo = 640.00m,
                    Equipo = new Equipo { Nombre = "Sonopuls 490" }
                }
            };
        }
    }
}
