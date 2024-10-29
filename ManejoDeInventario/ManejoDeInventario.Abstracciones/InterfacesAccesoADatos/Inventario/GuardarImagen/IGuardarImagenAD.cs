using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.GuardarImagen
{
    public interface IGuardarImagenAD
    {
        Task<int> Guardar(AdjuntosRepuestos laImagenAGuardar);
    }
}
