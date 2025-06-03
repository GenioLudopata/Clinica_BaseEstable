using System.Collections.Generic;
using Clinica.Models;

namespace Clinica.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public ICollection<Visita> Visitas { get; set; }
        public ICollection<Receta> Recetas { get; set; }
    }
}
