using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Terapeutas
{
    public class DetailsModel : PageModel
    {
        public Terapeuta Terapeuta { get; set; }

        public void OnGet(int id)
        {
            Terapeuta = new Terapeuta
            {
                Id = id,
                Nombre = "Lic. Ejemplo",
                Honorarios = 650,
                Telefono = "5554447788",
                Email = "ejemplo@clinica.com",
                Licencia = "LIC777"
            };
        }
    }
}
