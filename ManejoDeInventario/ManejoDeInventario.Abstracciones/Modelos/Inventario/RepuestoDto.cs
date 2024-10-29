using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ManejoDeInventario.Abstracciones.Modelos.Inventario
{
    public class RepuestoDto
    {
        public int Id { get; set; }
        [DisplayName("Código del repuesto")]
        [Required]
        [MinLength(4)]
        public string CodigoDelRepuesto { get; set; }
        [DisplayName("Nombre del repuesto")]
        public string NombreDelRepuesto { get; set; }
        [DisplayName("Marca del vehículo")]
        public string Vehiculo { get; set; }
        public string Modelo { get; set; }
        public string MarcaDelRepuesto { get; set; }
        public string Anio { get; set; }
        public int Cantidad { get; set; }
        public string FechaDeRegistro { get; set; }
        public string FechaDeModificacion { get; set; }
        public bool Estado { get; set; }
        public HttpPostedFileBase Archivo { get; set; }
        public string NombreDeArchivo { get; set; }
        public string Path { get; set; }
        public string Base64Imagen { get; set; }
    }
}
