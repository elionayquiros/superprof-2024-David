using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System.Collections.Generic;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Listar
{
    public interface IListarRepuestosAD
    {
        List<RepuestoDto> Listar();
    }
}
