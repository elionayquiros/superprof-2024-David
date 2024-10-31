using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using System.Threading.Tasks;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar
{
    public interface IRegistrarFlotaAdministrativaLN
    {
        Task<int> Registrar(FlotaAdministrativaDto vehiculo);
    }
}
