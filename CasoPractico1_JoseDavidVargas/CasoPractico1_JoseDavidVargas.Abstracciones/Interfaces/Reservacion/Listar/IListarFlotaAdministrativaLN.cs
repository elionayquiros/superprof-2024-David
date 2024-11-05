using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.Reservacion;
using System.Collections.Generic;

namespace CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar
{
    public interface IListarReservacionLN
    {
        List<ReservacionDto> Listar();
    }
}
