using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Medicos
{
    public class AdministrarModel : PageModel
    {
        public List<Medico> ListaMedicos { get; set; }

        public void OnGet()
        {
            // Datos de prueba (punteros)
            ListaMedicos = new List<Medico>
            {
                new Medico
                {
                    Id = 1,
                    Nombre = "Dra. Ana Ramírez",
                    Especialidad = "Fisioterapia Deportiva",
                    Telefono = "555-123-4567",
                    Email = "ana.ramirez@clinicafisica.com"
                },
                new Medico
                {
                    Id = 2,
                    Nombre = "Dr. Carlos Méndez",
                    Especialidad = "Ortopedia",
                    Telefono = "555-987-6543",
                    Email = "carlos.mendez@clinicafisica.com"
                }
            };
        }
    }
}
