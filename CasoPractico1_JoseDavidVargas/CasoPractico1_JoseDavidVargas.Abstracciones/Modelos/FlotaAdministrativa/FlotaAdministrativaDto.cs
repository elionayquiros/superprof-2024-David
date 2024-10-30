using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa
{
    public class FlotaAdministrativaDto
    {        
        public int Id { get; set; }
        [DisplayName("Marca del automóvil")]
        [Required]
        public string Marca { get; set; }
        [DisplayName("Modelo del automóvil")]
        [Required]
        public string Modelo { get; set; }
        [DisplayName("Modelo del automóvil")]
        [Required]
        [MinLength(4),MaxLength(4)]
        public string Anio { get; set; }
        
        [DisplayName("1= Sedan compacto, 2=SUV Compacto, 3=SUV Premium)")]
        [Required]
        //buscar dataannotation para restringir valores a 1, 2 y 3        
        public int TipoDeVehiculo { get; set; }

        [DisplayName("Monto por día")]
        [Required]
        public double MontoPorDia { get; set; }
        [DisplayName("Monto de seguro por día")]        
        public double MontoDeSeguro { get; set; }
        [DisplayName("Fecha de registro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }
        [DisplayName("Fecha de modificación")]        
        public DateTime FechaDeModificacion { get; set; }
        [DisplayName("Estado")]
        [Required]
        public bool Estado { get; set; }
    }
}

