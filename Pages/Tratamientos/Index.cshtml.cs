using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Tratamientos
{
    public class IndexModel : PageModel
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
                    Nombre = "Electroterapia",
                    Tipo = "Estimulación eléctrica",
                    Descripcion = "Tratamiento con corrientes eléctricas para aliviar el dolor.",
                    Costo = 450.00m,
                    Equipo = new Equipo
                    {
                        Nombre = "TENS Portátil"
                    }
                },
                new Tratamiento
                {
                    Id = 2,
                    Nombre = "Ultrasonido terapéutico",
                    Tipo = "Terapia física",
                    Descripcion = "Ondas ultrasónicas para tratar lesiones profundas.",
                    Costo = 600.00m,
                    Equipo = new Equipo
                    {
                        Nombre = "Sonopuls 492"
                    }
                }
            };
        }
    }
}
