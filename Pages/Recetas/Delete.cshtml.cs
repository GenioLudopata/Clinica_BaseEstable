using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Recetas
{
    public class DeleteModel : PageModel
    {
        public Receta Receta { get; set; }

        public void OnGet(int id)
        {
            Receta = new Receta
            {
                Id = id,
                Medicamento = "Eliminar",
                Fecha = DateTime.Today,
                Descripcion = "Eliminar receta",
                DuracionDias = 2
            };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Receta con ID {id} eliminada correctamente.";
            return RedirectToPage("Index");
        }
    }
}