using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Tratamientos
{
    public class DeleteModel : PageModel
    {
        public Tratamiento Tratamiento { get; set; }

        public void OnGet(int id)
        {
            Tratamiento = new Tratamiento
            {
                Id = id,
                Nombre = "Eliminar",
                Tipo = "Demo",
                Descripcion = "Eliminar tratamiento",
                Costo = 350
            };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Tratamiento con ID {id} eliminado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
