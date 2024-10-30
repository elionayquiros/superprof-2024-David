using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos
{
    [Table("FLOTA_ADMINISTRATIVA")]
    public class FlotaAdministrativaBD
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Anio { get; set; }
        public int TipoDeVehiculo { get; set; }
        public double MontoPorDia { get; set; }
        public double MontoDeSeguro { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeModificacion { get; set; }
        public bool Estado { get; set; }

    }
}

