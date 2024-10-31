using System.Collections.Generic;
using System.Linq;
using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Listar;

namespace CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar
{
    public class ListarFlotaAdministrativaLN : IListarFlotaAdministrativaLN
    {
        IListarFlotaAdministrativaAD _listarFlota;
        public ListarFlotaAdministrativaLN()
        {
            _listarFlota = new ListarFlotaAdministrativaAD();
        }

        public List<FlotaAdministrativaDto> Listar()
        {
            //Se transforma el objeto de bd a Dto
            List<FlotaAdministrativaDto> listarFLotillaTotal = (from vehiculo in _listarFlota.Listar()                                                                
                                                                 select new FlotaAdministrativaDto
                                                                 {
                                                                     Id = vehiculo.Id,
                                                                     Marca = vehiculo.Marca,
                                                                     Modelo = vehiculo.Modelo,
                                                                     Anio = vehiculo.Anio,
                                                                     TipoDeVehiculo = vehiculo.TipoDeVehiculo,
                                                                     MontoPorDia = vehiculo.MontoPorDia,
                                                                     MontoDeSeguro = vehiculo.MontoDeSeguro,
                                                                     FechaDeRegistro = vehiculo.FechaDeRegistro,
                                                                     FechaDeModificacion = vehiculo.FechaDeModificacion,
                                                                     Estado = vehiculo.Estado
                                                                 }).ToList();
            return listarFLotillaTotal;
        }
    }
}
