using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Visitas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Visita VisitaEditada { get; set; }

        public IActionResult OnGet(int id)
        {
            VisitaEditada = new Visita { Id = id, Fecha = DateTime.Today, Hora = TimeSpan.Parse( "10:30"), Notas = "Modificada", Duracion = 50 };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            TempData["Mensaje"] = "Visita actualizada correctamente.";
            return RedirectToPage("Index");
        }
    }
}
