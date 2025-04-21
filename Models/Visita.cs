namespace Clinica.Models
{
    public class Visita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Notas { get; set; }
        public int Duracion { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int TerapeutaId { get; set; }
        public Terapeuta Terapeuta { get; set; }

        public int TratamientoId { get; set; }
        public Tratamiento Tratamiento { get; set; }
    }
}
