using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Tratamientos
{
    public class DetailsModel : PageModel
    {
        public Tratamiento Tratamiento { get; set; }

        public void OnGet(int id)
        {
            Tratamiento = new Tratamiento
            {
                Id = id,
                Nombre = "Ejemplo",
                Tipo = "Detalle",
                Descripcion = "Consulta detallada",
                Costo = 400
            };
        }
    }
}

