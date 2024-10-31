using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;

namespace CasoPractico1_JoseDavidVargas.AccesoADatos
{
    public class Contexto : DbContext
    {        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlotaAdministrativaBD>().ToTable("FLOTA_ADMINISTRATIVA");
            //modelBuilder.Entity<AdjuntosRepuestos>().ToTable("AdjuntosRepuestos");

        }
        public DbSet<FlotaAdministrativaBD> FlotaAdministrativa { get; set; }
        //public DbSet<AdjuntosRepuestos> AdjuntosRepuestos { get; set; }
        
    }
}

