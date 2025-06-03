using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;
using System;
using System.Collections.Generic;

namespace Clinica.Pages.Visitas
{
    public class IndexModel : PageModel
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
                    Hora = new TimeSpan(9, 0, 0),
                    Duracion = 45,
                    Notas = "Sesión de evaluación inicial",
                    Paciente = new Paciente { Nombre = "Gabriela Torres" },
                    Terapeuta = new Terapeuta { Nombre = "Luis Martínez" },
                    Tratamiento = new Tratamiento { Nombre = "Terapia con calor húmedo" }
                },
                new Visita
                {
                    Id = 2,
                    Fecha = DateTime.Today.AddDays(-2),
                    Hora = new TimeSpan(11, 30, 0),
                    Duracion = 60,
                    Notas = "Revisión de progreso y ajustes",
                    Paciente = new Paciente { Nombre = "Mario Aguilar" },
                    Terapeuta = new Terapeuta { Nombre = "Carmen Pérez" },
                    Tratamiento = new Tratamiento { Nombre = "Electroestimulación muscular" }
                }
            };
        }
    }
}
