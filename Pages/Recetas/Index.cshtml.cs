using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Recetas
{
    public class IndexModel : PageModel
    {
        public List<Receta> ListaRecetas { get; set; }

        public void OnGet()
        {
            ListaRecetas = new List<Receta>
            {
                new Receta { Id = 1, Medicamento = "Ibuprofeno", Fecha = DateTime.Today.AddDays(-2), Descripcion = "Para el dolor", DuracionDias = 5 },
                new Receta { Id = 2, Medicamento = "Paracetamol", Fecha = DateTime.Today.AddDays(-1), Descripcion = "Fiebre y malestar", DuracionDias = 3 }
            };
        }
    }
}










