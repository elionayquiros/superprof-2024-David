using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.Reservacion
{
    public class ReservacionDto
    {
                
        public int Id { get; set; }

        [Required]
        //[StringLength(150)]
        [DisplayName("Nombre del cliente")]
        public string NombreCliente { get; set; }

        [Required]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required]        
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }

        [Required]
        [DisplayName("Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [DisplayName("Tarjeta de crédito")]
        [MaxLength(4),MinLength(4)]
        public string TarjetaDeCredito { get; set; }

        [Required]
        [DisplayName("Id del vehículo")]
        public int IdVehiculo { get; set; }

        [Required]
        [DisplayName("Monto por día")]
        [DataType(DataType.Currency)]
        public decimal MontoPorDia { get; set; }

        [Required]
        [DisplayName("Monto de seguro")]
        [DataType(DataType.Currency)]
        public decimal MontoSeguro { get; set; }

        [Required]
        [DisplayName("Reservado desde")]
        [DataType(DataType.DateTime)]
        public DateTime FechaInicio { get; set; }

        [Required]
        [DisplayName("Reservado hasta")]
        [DataType(DataType.DateTime)]
        public DateTime FechaFin { get; set; }

        [DisplayName("Registrada el")]
        [DataType(DataType.DateTime)]
        public DateTime? FechaDeRegistro { get; set; }

        [Required]
        [DisplayName("Cantidad de días")]        
        public int CantidadDeDias {
            get
            {
                return (FechaFin - FechaInicio).Days;
            }
        }

        [NotMapped]
        [DisplayName("Precio total")]
        public decimal PrecioTotal {
            //set { }
            get
            {
                return (CantidadDeDias * MontoPorDia) + MontoSeguro;
            }
        }

        [Required]        
        public bool Estado { get; set; }
        
        [NotMapped]
        [DisplayName("Estado")]
        public String DetalleEstado
        {
            //set { }
            get
            {
                if (Estado = true)
                    return "Reservado";
                else
                    return "Reserva vencida";
            }
        }   
    }
}