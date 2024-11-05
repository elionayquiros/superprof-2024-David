using CasoPractico1_JoseDavidVargas.Abstracciones.ModelosAccesoADatos;
using System.Collections.Generic;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.InterfacesAccesoADatos.Reservacion.Listar
{
    public interface IListarReservacionAD
    {
        List<ReservacionBD> Listar();
    }
}

