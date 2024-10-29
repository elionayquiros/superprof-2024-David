using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Guardar
{
    public interface IGuardarRepuestosAD
    {
        Task<int> Guardar(Repuestos elRepuestoAGuardar);
    }
}
