using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos
{
    [Table("FLOTA_ADMINISTRATIVA")]
    public class FlotaAdministrativaBD
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Anio { get; set; }
        public int TipoDeVehiculo { get; set; }
        public decimal MontoPorDia { get; set; }
        public decimal MontoDeSeguro { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }

    }
}

