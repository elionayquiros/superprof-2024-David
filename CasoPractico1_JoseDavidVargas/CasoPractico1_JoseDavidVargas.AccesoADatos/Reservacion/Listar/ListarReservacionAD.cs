using System.Collections.Generic;
using System.Linq;
using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.Reservacion.Listar;

namespace CasoPractico1_JoseDavidVargas.AccesoADatos.FlotaAdministrativa.Listar
{
    public class ListarReservacionAD : IListarReservacionAD
    {
        Contexto conexionABD;

        public ListarReservacionAD()
        {
            conexionABD = new Contexto();
        }  

        List<ReservacionBD> IListarReservacionAD.Listar()
        {
            return conexionABD.Reservacion.ToList();
        }
    }
}
