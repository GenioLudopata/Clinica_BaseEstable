using System.Collections.Generic;
using Clinica.Models;

namespace Clinica.Models
{
    public class Terapeuta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Honorarios { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Licencia { get; set; }

        public ICollection<Visita> Visitas { get; set; }
    }
}
