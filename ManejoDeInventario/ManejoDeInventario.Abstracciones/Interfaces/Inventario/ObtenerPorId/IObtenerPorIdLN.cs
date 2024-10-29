using ManejoDeInventario.Abstracciones.Modelos.Inventario;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.ObtenerPorId
{
    public interface IObtenerPorIdLN
    {
        RepuestoDto Obtener(int Id);
    }
}
