using System;
using System.Threading.Tasks;
using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Guardar;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using System.Net.Http.Headers;
using System.Collections.Specialized;

namespace CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar
{
    public class RegistrarFlotaAdministrativaLN : IRegistrarFlotaAdministrativaLN
    {
        IRegistrarFlotaAdministrativaAD _guardarBD;
        public RegistrarFlotaAdministrativaLN()        
        {
            _guardarBD = new RegistrarFlotaAdministrativaAD();
        }
        
        public Task<int> Registrar(FlotaAdministrativaDto vehiculo)
        {
            return _guardarBD.Guardar(ConvertirObjeto(vehiculo));            
        }

        //se convierte el objeto de transferencia a un objeto de BD
        private FlotaAdministrativaBD ConvertirObjeto(FlotaAdministrativaDto vehiculo)
        {
            return new FlotaAdministrativaBD
                    {
                        //Id = vehiculo.Id,
                        Modelo = vehiculo.Modelo,
                        Marca = vehiculo.Marca,
                        Anio = vehiculo.Anio,
                        TipoDeVehiculo = vehiculo.TipoDeVehiculo,
                        MontoPorDia = vehiculo.MontoPorDia,
                        MontoDeSeguro = vehiculo.MontoDeSeguro,
                        FechaDeRegistro = vehiculo.FechaDeRegistro,
                        FechaDeModificacion = vehiculo.FechaDeModificacion,
                        Estado = vehiculo.Estado        
                    };
            

        }
    }
}


