using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar;

namespace CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Listar
{
    public class ListarFlotaAdministrativaAD:IFlotaAdministrativaAD
    {
        Contexto elContexto;

        public ListarFlotaAdministrativaAD()
        {
            elContexto = new Contexto();
        }        
        public List<FlotaAdministrativaDto> Listar()
        {
            List<FlotaAdministrativaDto> laFlotaTotal = (from vehiculo in elContexto.FlotaAdministrativa                                                  
                                                          select new FlotaAdministrativaDto
                                                          {
                                                              Id = vehiculo.Id,
                                                              Marca = vehiculo.Marca,
                                                              Modelo = vehiculo.Modelo,
                                                              Anio = vehiculo.Anio,
                                                              TipoDeVehiculo= vehiculo.TipoDeVehiculo,
                                                              MontoPorDia = vehiculo.MontoPorDia,
                                                              MontoDeSeguro= vehiculo.MontoDeSeguro,
                                                              FechaDeRegistro= vehiculo.FechaDeRegistro,
                                                              FechaDeModificacion = vehiculo.FechaDeModificacion,
                                                              Estado= vehiculo.Estado
                                                          }).ToList();
            return laFlotaTotal;
        }

    }
}
