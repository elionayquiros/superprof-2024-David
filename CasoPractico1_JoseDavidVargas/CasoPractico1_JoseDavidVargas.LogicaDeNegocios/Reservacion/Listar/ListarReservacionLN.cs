using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.Reservacion.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.Reservacion;
using CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Listar;
using System.Collections.Generic;
using System.Linq;

namespace CasoPractico1_JoseDavidVargas.LogicaDeNegocios.Reservacion.Listar
{
    public class ListarReservacionLN : IListarReservacionLN
    {
        IListarReservacionAD _listarReservacion;
        public ListarReservacionLN()
        {
            _listarReservacion = new ListarReservacionAD();
        }
        public List<ReservacionDto> Listar()
        {
            //Se transforma el objeto de bd a Dto
            List<ReservacionDto> listaReservaciones = (from reservacion in _listarReservacion.Listar()
                                                                select new ReservacionDto
                                                                {
                                                                    Id = reservacion.Id,                                                                    
                                                                    NombreCliente = reservacion.NombreCliente,
                                                                    Telefono = reservacion.Telefono,
                                                                    Correo = reservacion.Correo,
                                                                    Identificacion  = reservacion.Identificacion,
                                                                    FechaNacimiento = reservacion.FechaNacimiento,
                                                                    TarjetaDeCredito = reservacion.TarjetaDeCredito,
                                                                    IdVehiculo = reservacion.IdVehiculo,
                                                                    MontoPorDia = reservacion.MontoPorDia,
                                                                    MontoSeguro = reservacion.MontoSeguro,
                                                                    FechaInicio = reservacion.FechaInicio,
                                                                    FechaFin = reservacion.FechaFin,
                                                                    FechaDeRegistro = reservacion.FechaDeRegistro,                                                                    
                                                                    Estado=reservacion.Estado
                                                                }).ToList();
            return listaReservaciones;
        }
    }
}