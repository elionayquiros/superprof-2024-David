using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Eliminar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Eliminar;
using ManejoDeInventario.AccesoADatos.Inventario.Eliminar;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Eliminar
{
    public class EliminarInventarioLN : IEliminarInventarioLN
    {
        IEliminarRepuestoAD _eliminarRepuestoAD;
        public EliminarInventarioLN()
        {
            _eliminarRepuestoAD = new EliminarRepuestoAD();
        }

        public int Eliminar(int Id)
        {
            if (Id == 0)
            {
                return 0;
            }
            int cantidadDeElementosEliminados = _eliminarRepuestoAD.Eliminar(Id);
            return cantidadDeElementosEliminados;
        }
    }
}
