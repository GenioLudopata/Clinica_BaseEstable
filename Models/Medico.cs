using System.Collections.Generic;
using Clinica.Models;

namespace Clinica.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ICollection<Receta> RecetasEmitidas { get; set; }
    }
}
