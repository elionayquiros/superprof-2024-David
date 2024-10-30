using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos
{
	public class Contexto: DbContext
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Repuestos>().ToTable("Repuestos");
			modelBuilder.Entity<AdjuntosRepuestos>().ToTable("AdjuntosRepuestos");

		}
		public DbSet<Repuestos> Repuestos { get; set; }
		public DbSet<AdjuntosRepuestos> AdjuntosRepuestos { get; set; }
	}
}
