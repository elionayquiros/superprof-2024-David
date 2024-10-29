using System;

namespace ManejoDeInventario.Abstracciones.Interfaces.General.Fechas
{
    public interface IFechas
    {
        DateTime ObtenerFecha();
        DateTime ObtenerFechaUTC();
        DateTime ObtenerFechaMenosSeisHoras();
    }
}
