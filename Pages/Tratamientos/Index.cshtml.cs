using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Tratamientos
{
    public class IndexModel : PageModel
    {
        public List<Tratamiento> ListaTratamientos { get; set; }

        public void OnGet()
        {
            ListaTratamientos = new List<Tratamiento>
            {
                new Tratamiento { Id = 1, Nombre = "Electroterapia", Tipo = "Física", Descripcion = "Aplicación eléctrica terapéutica", Costo = 450 },
                new Tratamiento { Id = 2, Nombre = "Ultrasonido", Tipo = "Física", Descripcion = "Terapia de ondas sonoras", Costo = 500 }
            };
        }
    }
}








