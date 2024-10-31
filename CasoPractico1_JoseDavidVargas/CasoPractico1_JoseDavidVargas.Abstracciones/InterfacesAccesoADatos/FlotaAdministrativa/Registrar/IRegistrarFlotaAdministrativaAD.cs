using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using System.Threading.Tasks;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar
{
    public interface IRegistrarFlotaAdministrativaAD
    {
        Task<int> Guardar(FlotaAdministrativaBD vehiculo);
    }
}
