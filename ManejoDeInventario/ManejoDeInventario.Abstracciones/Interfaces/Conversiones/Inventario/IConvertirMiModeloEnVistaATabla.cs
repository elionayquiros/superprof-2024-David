using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;

namespace ManejoDeInventario.Abstracciones.Interfaces.Conversiones.Inventario
{
    public interface IConvertirMiModeloEnVistaATabla
    {
        Repuestos ObtenerRepuesto(RepuestoDto elRepuesto);
    }
}
