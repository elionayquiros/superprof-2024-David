using System.Data.Entity;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;

namespace CasoPractico1_JoseDavidVargas.AccesoADatos
{
    public class Contexto : DbContext
    {        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlotaAdministrativaBD>().ToTable("FLOTA_ADMINISTRATIVA");
            modelBuilder.Entity<ReservacionBD>().ToTable("RESERVACIONES");
        }
        public DbSet<FlotaAdministrativaBD> FlotaAdministrativa { get; set; }
        public DbSet<ReservacionBD> Reservacion { get; set; }
        
    }
}

