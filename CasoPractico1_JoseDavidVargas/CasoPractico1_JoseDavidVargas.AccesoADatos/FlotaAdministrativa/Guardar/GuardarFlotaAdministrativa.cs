using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Guardar
{
    public class RegistrarFlotaAdministrativaAD: IRegistrarFlotaAdministrativaAD
    {
		Contexto _elContexto;
		public RegistrarFlotaAdministrativaAD()
		{
			_elContexto = new Contexto ();
		}
        public async Task<int> Guardar(FlotaAdministrativaBD vehiculo)
        {
            _elContexto.FlotaAdministrativa.Add(vehiculo);
            EntityState estado = _elContexto.Entry(vehiculo).State = System.Data.Entity.EntityState.Added;
            int seGuardo = await _elContexto.SaveChangesAsync();
            return seGuardo;
        }
    }

}
