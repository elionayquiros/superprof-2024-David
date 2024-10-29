using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System.Collections.Generic;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.Listar
{
    public interface IListarRepuestosLN
    {
        List<RepuestoDto> Listar();
    }
}
