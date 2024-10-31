using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;

namespace CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar
{
    public class FlotaAdministrativaLN : IFlotaAdministrativaLN
    {
        IFlotaAdministrativaAD _listarFlota;
        public FlotaAdministrativaLN()
        {
            _listarFlota = new ListarFlotaAdministrativaAD();
        }

        public List<FlotaAdministrativaDto> Listar()
        {
            List<FlotaAdministrativaDto> listarFLotillaTotal = _listarFlota.Listar();
            return listarFLotillaTotal;
        }
    }
}
