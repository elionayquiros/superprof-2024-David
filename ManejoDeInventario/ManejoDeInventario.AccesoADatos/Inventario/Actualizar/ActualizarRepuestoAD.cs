using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System.Data.Entity;
using System.Linq;

namespace ManejoDeInventario.AccesoADatos.Inventario.Actualizar
{
    public class ActualizarRepuestoAD : IActualizarRepuestoAD
    {
        Contexto _elContexto;
        public ActualizarRepuestoAD()
        {
            _elContexto = new Contexto();
        }
        public int Actualizar(Repuestos elRepuestoParaActualizar)
        {
            Repuestos elRepuesto = _elContexto.Repuestos.Where(repuesto => repuesto.Id == elRepuestoParaActualizar.Id).FirstOrDefault();
            elRepuesto.NombreDelRepuesto = elRepuestoParaActualizar.NombreDelRepuesto;
            elRepuesto.MarcaDelRepuesto = elRepuestoParaActualizar.MarcaDelRepuesto;
            EntityState estado = _elContexto.Entry(elRepuesto).State = System.Data.Entity.EntityState.Modified;
            int seGuardoElRepuesto = _elContexto.SaveChanges();
            return seGuardoElRepuesto;
        }
    }
}
