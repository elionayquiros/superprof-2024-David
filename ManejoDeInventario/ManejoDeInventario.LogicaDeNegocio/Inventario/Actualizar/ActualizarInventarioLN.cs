using ManejoDeInventario.Abstracciones.Interfaces.Conversiones.Inventario;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Actualizar;
using ManejoDeInventario.LogicaDeNegocio.Conversiones.Inventario;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Actualizar
{
    public class ActualizarInventarioLN : IActualizarInventarioLN
    {
        IActualizarRepuestoAD _actualizarRepuestosAD;
        IConvertirMiModeloEnVistaATabla _convertirModelo;
        public ActualizarInventarioLN()
        {
            _actualizarRepuestosAD = new ActualizarRepuestoAD();
            _convertirModelo = new ConvertirMiModeloEnVistaATabla();
        }

        public int Actualizar(RepuestoDto elRepuestoParaActualizar)
        {
            Repuestos elRepuestoConvertido = _convertirModelo.ObtenerRepuesto(elRepuestoParaActualizar);
            int seGuardoElRepuesto = _actualizarRepuestosAD.Actualizar(elRepuestoConvertido);
            return seGuardoElRepuesto;
        }



    }
}
