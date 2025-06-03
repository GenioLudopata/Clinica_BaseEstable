using System.Collections.Generic;
using Clinica.Models;

namespace Clinica.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Medicamento { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int DuracionDias { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
}
