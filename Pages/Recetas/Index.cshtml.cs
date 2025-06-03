using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;
using System;

namespace Clinica.Pages.Recetas
{
    public class IndexModel : PageModel
    {
        public List<Receta> ListaRecetas { get; set; }

        public void OnGet()
        {
            // Datos de ejemplo con relaciones simuladas
            ListaRecetas = new List<Receta>
            {
                new Receta
                {
                    Id = 1,
                    Fecha = new DateTime(2024, 11, 1),
                    Descripcion = "Dolor lumbar crónico",
                    Paciente = new Paciente { Nombre = "Ana Pérez" },
                    Medico = new Medico { Nombre = "Dr. Juan Gómez" }
                },
                new Receta
                {
                    Id = 2,
                    Fecha = new DateTime(2025, 2, 18),
                    Descripcion = "Rehabilitación postoperatoria",
                    Paciente = new Paciente { Nombre = "Luis Ortega" },
                    Medico = new Medico { Nombre = "Dra. Gabriela Ruiz" }
                }
            };
        }
    }
}


