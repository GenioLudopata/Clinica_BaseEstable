using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;
using System;

namespace Clinica.Pages.Recetas
{
    public class AdministrarModel : PageModel
    {
        public List<Receta> ListaRecetas { get; set; }

        public void OnGet()
        {
            // Lista simulada de recetas
            ListaRecetas = new List<Receta>
            {
                new Receta
                {
                    Id = 1,
                    Fecha = new DateTime(2024, 10, 5),
                    Descripcion = "Lesión de rodilla",
                    Paciente = new Paciente { Nombre = "Sofía Ramírez" },
                    Medico = new Medico { Nombre = "Dr. Andrés Herrera" }
                },
                new Receta
                {
                    Id = 2,
                    Fecha = new DateTime(2025, 1, 22),
                    Descripcion = "Rehabilitación post fractura",
                    Paciente = new Paciente { Nombre = "Marco Dávila" },
                    Medico = new Medico { Nombre = "Dra. Carla Soto" }
                }
            };
        }
    }
}
