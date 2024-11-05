using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using System.Collections.Generic;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar
{
    public interface IListarFlotaAdministrativaLN
    {
        List<FlotaAdministrativaDto> Listar();
    }
}
