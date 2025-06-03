using System.Collections.Generic;
using Clinica.Models;

namespace Clinica.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
