using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;
using System;

namespace Clinica.Pages.Pacientes
{
    public class AdministrarModel : PageModel
    {
        public List<Paciente> ListaPacientes { get; set; }

        public void OnGet()
        {
            // Datos de ejemplo
            ListaPacientes = new List<Paciente>
            {
                new Paciente
                {
                    Id = 1,
                    Nombre = "María López",
                    FechaNacimiento = new DateTime(1992, 3, 15),
                    Direccion = "Av. Reforma 123",
                    Telefono = "555-123-4567"
                },
                new Paciente
                {
                    Id = 2,
                    Nombre = "Carlos Rodríguez",
                    FechaNacimiento = new DateTime(1980, 7, 9),
                    Direccion = "Calle 8 No. 55",
                    Telefono = "555-987-6543"
                }
            };
        }
    }
}
