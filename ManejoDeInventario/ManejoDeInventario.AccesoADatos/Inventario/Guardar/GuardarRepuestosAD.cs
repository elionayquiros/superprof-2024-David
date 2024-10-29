
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Guardar;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.Guardar
{
    public class GuardarRepuestosAD : IGuardarRepuestosAD
    {
        Contexto _elContexto;
        public GuardarRepuestosAD()
        {
            _elContexto = new Contexto();
        }
        public async Task<int> Guardar(Repuestos elRepuestoAGuardar)
        {
            _elContexto.Repuestos.Add(elRepuestoAGuardar);
            EntityState estado = _elContexto.Entry(elRepuestoAGuardar).State = System.Data.Entity.EntityState.Added;
            int seGuardoElRepuesto = await _elContexto.SaveChangesAsync();
            return seGuardoElRepuesto;
        }
    }
}
