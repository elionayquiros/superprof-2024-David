using ManejoDeInventario.Abstracciones.Interfaces.Clientes.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Clientes;
using System.Collections.Generic;

namespace ManejoDeInventario.LogicaDeNegocio.Clientes.Listar
{
    public class ListarClientesLN : IListarClientesLN
    {
        public List<ClientesDto> Listar()
        {
            List<ClientesDto> laListaDeClientes = new List<ClientesDto>();
            laListaDeClientes.Add(ObtenerClienteUno());
            return laListaDeClientes;
        }

        private ClientesDto ObtenerClienteUno()
        {
            return new ClientesDto
            {
                Correo = "correo@gmail.com",
                Estado = true,
                //FechaDeModificacion = DateTime.Now,
                //FechaDeRegistro = DateTime.Now,
                Identificación = "00-0000-0000",
                Nombre = "Nombre",
                PrimerApellido = "Apellido",
                SegundoApellido = "Apellido",
                Telefono = "88888888"
            };
        }
    }
}
