using ManejoDeInventario.Abstracciones.Modelos.Inventario;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.Actualizar
{
    public interface IActualizarInventarioLN
    {
        int Actualizar(RepuestoDto elRepuestoParaActualizar);
    }
}
