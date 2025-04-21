using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Recetas
{
    public class DetailsModel : PageModel
    {
        public Receta Receta { get; set; }

        public void OnGet(int id)
        {
            Receta = new Receta
            {
                Id = id,
                Medicamento = "Ejemplo",
                Fecha = DateTime.Today.AddDays(-3),
                Descripcion = "Ver detalles de receta",
                DuracionDias = 4
            };
        }
    }
}