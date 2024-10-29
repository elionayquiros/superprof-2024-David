using ManejoDeInventario.Abstracciones.Modelos.Clientes;
using System.Collections.Generic;

namespace ManejoDeInventario.Abstracciones.Interfaces.Clientes.Listar
{
    public interface IListarClientesLN
    {
        List<ClientesDto> Listar();
    }
}
