using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clinica.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Contrasena { get; set; }

        public string Mensaje { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Login simulado (puedes cambiar por consulta a BD)
            if (Usuario == "admin" && Contrasena == "1234")
            {
                return Redirect("/Index");

            }

            Mensaje = "Usuario o contraseña incorrectos.";
            return Page();
        }
    }
}
