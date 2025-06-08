using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System.Collections.Generic;

namespace Clinica.Pages.Terapeutas
{
    public class AdministrarModel : PageModel
    {
        public List<Terapeuta> ListaTerapeutas { get; set; }

        public void OnGet()
        {
            // Datos simulados de prueba
            ListaTerapeutas = new List<Terapeuta>
            {
                new Terapeuta
                {
                    Id = 1,
                    Nombre = "Fernanda Díaz",
                    Telefono = "555-123-4567",
                    Email = "fernanda.diaz@clinica.com",
                    Licencia = "LIC-09876",
                    Honorarios = 900.00m
                },
                new Terapeuta
                {
                    Id = 2,
                    Nombre = "Carlos Méndez",
                    Telefono = "555-765-4321",
                    Email = "carlos.mendez@clinica.com",
                    Licencia = "LIC-04567",
                    Honorarios = 850.00m
                }
            };
        }
    }
}
