using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Visitas
{
    public class DeleteModel : PageModel
    {
        public Visita Visita { get; set; }

        public void OnGet(int id)
        {
            Visita = new Visita { Id = id, Fecha = DateTime.Today, Hora =TimeSpan.Parse( "14:00"), Notas = "Eliminar esta visita", Duracion = 30 };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Visita con ID {id} eliminada correctamente.";
            return RedirectToPage("Index");
        }
    }
}
