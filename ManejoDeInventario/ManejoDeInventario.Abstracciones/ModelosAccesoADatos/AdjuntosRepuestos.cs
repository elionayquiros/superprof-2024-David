using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManejoDeInventario.Abstracciones.ModelosAccesoADatos
{
    [Table("AdjuntosRepuestos")]
    public class AdjuntosRepuestos
    {
        public int Id { get; set; }
        public string Adjunto { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdRepuesto { get; set; }
    }
}
