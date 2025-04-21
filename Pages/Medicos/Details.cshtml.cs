using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Medicos
{
    public class DetailsModel : PageModel
    {
        public Medico Medico { get; set; }

        public void OnGet(int id)
        {
            Medico = new Medico
            {
                Id = id,
                Nombre = "Dra. Ejemplo",
                Especialidad = "Reumatología",
                Telefono = "5554447788",
                Email = "ejemplo@example.com"
            };
        }
    }
}