using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System;
using System.Collections.Generic;

namespace Clinica.Pages.Visitas
{
    public class AdministrarModel : PageModel
    {
        public List<Visita> ListaVisitas { get; set; }

        public void OnGet()
        {
            ListaVisitas = new List<Visita>
            {
                new Visita
                {
                    Id = 1,
                    Fecha = DateTime.Today,
                    Hora = new TimeSpan(9, 30, 0),
                    Duracion = 50,
                    Notas = "Control mensual",
                    Paciente = new Paciente { Nombre = "Alejandra Cruz" },
                    Terapeuta = new Terapeuta { Nombre = "Javier Morales" },
                    Tratamiento = new Tratamiento { Nombre = "Rehabilitación lumbar" }
                },
                new Visita
                {
                    Id = 2,
                    Fecha = DateTime.Today.AddDays(-3),
                    Hora = new TimeSpan(14, 0, 0),
                    Duracion = 60,
                    Notas = "Ejercicios de movilidad",
                    Paciente = new Paciente { Nombre = "Fernando Ruiz" },
                    Terapeuta = new Terapeuta { Nombre = "Laura Delgado" },
                    Tratamiento = new Tratamiento { Nombre = "Terapia de estiramiento" }
                }
            };
        }
    }
}
