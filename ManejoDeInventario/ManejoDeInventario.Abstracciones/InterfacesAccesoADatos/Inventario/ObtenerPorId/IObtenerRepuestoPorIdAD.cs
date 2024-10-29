using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.ObtenerPorId
{
    public interface IObtenerRepuestoPorIdAD
    {
        Repuestos Obtener(int Id);
    }
}
