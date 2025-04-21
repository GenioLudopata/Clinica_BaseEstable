using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Terapeutas
{
    public class DeleteModel : PageModel
    {
        public Terapeuta Terapeuta { get; set; }

        public void OnGet(int id)
        {
            Terapeuta = new Terapeuta
            {
                Id = id,
                Nombre = "Lic. A eliminar",
                Honorarios = 500,
                Telefono = "5559990000",
                Email = "eliminar@clinica.com",
                Licencia = "LICDEL"
            };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Terapeuta con ID {id} eliminado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
