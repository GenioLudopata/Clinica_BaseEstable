using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Medicos
{
    public class DeleteModel : PageModel
    {
        public Medico Medico { get; set; }

        public void OnGet(int id)
        {
            Medico = new Medico
            {
                Id = id,
                Nombre = "Dr. A eliminar",
                Especialidad = "Neurología",
                Telefono = "5559990000",
                Email = "eliminar@example.com"
            };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Médico con ID {id} eliminado correctamente.";
            return RedirectToPage("Index");
        }
    }
}
