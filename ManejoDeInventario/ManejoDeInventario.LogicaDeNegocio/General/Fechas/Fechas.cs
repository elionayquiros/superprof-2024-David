using ManejoDeInventario.Abstracciones.Interfaces.General.Fechas;
using System;

namespace ManejoDeInventario.LogicaDeNegocio.General.Fechas
{
    public class Fechas : IFechas
    {

        public DateTime ObtenerFecha()
        {
            return DateTime.Now;
        }

        public DateTime ObtenerFechaUTC()
        {
            return DateTime.UtcNow;
        }

        public DateTime ObtenerFechaMenosSeisHoras()
        {
            return DateTime.UtcNow.AddHours(-6);
        }
    }
}
