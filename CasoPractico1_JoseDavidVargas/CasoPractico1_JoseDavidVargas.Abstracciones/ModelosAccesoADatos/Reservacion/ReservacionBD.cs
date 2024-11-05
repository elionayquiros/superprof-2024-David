using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos
{
    [Table("RESERVACIONES")]
    public class ReservacionBD
    {
        [Key]        
        public int Id { get; set; }

        [Required]        
        public string NombreCliente { get; set; }

        [Required]        
        public string Telefono { get; set; }

        [Required]        
        public string Correo { get; set; }

        [Required]        
        public string Identificacion { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]        
        public string TarjetaDeCredito { get; set; }

        [Required]
        public int IdVehiculo { get; set; }

        [Required]        
        public decimal MontoPorDia { get; set; }

        [Required]        
        public decimal MontoSeguro { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        public DateTime? FechaDeRegistro { get; set; }

        [Required]
        public int CantidadDeDias { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
