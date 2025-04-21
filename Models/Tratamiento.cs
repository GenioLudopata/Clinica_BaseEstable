namespace Clinica.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }

        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }

        public ICollection<Visita> Visitas { get; set; }
    }
}
