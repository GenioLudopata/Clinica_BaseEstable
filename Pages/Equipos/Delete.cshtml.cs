using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clinica.Models;

namespace Clinica.Pages.Equipos
{
    public class DeleteModel : PageModel
    {
        public Equipo Equipo { get; set; }

        public void OnGet(int id)
        {
            Equipo = new Equipo { Id = id, Nombre = "Eliminar", Descripcion = "Eliminar este equipo", Marca = "DeleteMarca", Modelo = "DEL-001" };
        }

        public IActionResult OnPost(int id)
        {
            TempData["Mensaje"] = $"Equipo con ID {id} eliminado correctamente.";
            return RedirectToPage("Index");
        }
    }
}