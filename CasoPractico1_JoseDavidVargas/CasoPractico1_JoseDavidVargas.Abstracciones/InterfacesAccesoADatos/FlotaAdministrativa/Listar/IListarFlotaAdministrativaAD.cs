using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using System.Collections.Generic;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar
{
    public interface IListarFlotaAdministrativaAD
    {
        List<FlotaAdministrativaBD> Listar();      
    }
}
