using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar
{
    public interface IActualizarRepuestoAD
    {
        int Actualizar(Repuestos elRepuestoParaActualizar);
    }
}
