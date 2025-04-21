using Microsoft.EntityFrameworkCore;
using Clinica.Models;


namespace Clinica.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Terapeuta> Terapeutas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<Visita> Visitas { get; set; }
    }
}