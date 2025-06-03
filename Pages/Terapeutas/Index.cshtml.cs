using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Terapeutas
{
    public class IndexModel : PageModel
    {
        public List<Terapeuta> ListaTerapeutas { get; set; }

        public void OnGet()
        {
            // Datos simulados para pruebas visuales
            ListaTerapeutas = new List<Terapeuta>
            {
                new Terapeuta
                {
                    Id = 1,
                    Nombre = "Andrea Moreno",
                    Honorarios = 850.00m,
                    Telefono = "555-432-1987",
                    Email = "andrea.moreno@clinica.com",
                    Licencia = "TER-10293"
                },
                new Terapeuta
                {
                    Id = 2,
                    Nombre = "Luis Ramírez",
                    Honorarios = 780.00m,
                    Telefono = "555-867-3245",
                    Email = "luis.ramirez@clinica.com",
                    Licencia = "TER-20476"
                }
            };
        }
    }
}




