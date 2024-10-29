using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System.Collections.Generic;
using System.Linq;

namespace ManejoDeInventario.AccesoADatos.Inventario.Listar
{
    public class ListarRepuestosAD : IListarRepuestosAD
    {
        Contexto elContexto;

        public ListarRepuestosAD()
        {
            elContexto = new Contexto();
        }

        public List<RepuestoDto> Listar()
        {
            List<RepuestoDto> losRepuestos = (from inventario in elContexto.Repuestos
                                                  //join imagenEnBD in elContexto.AdjuntosRepuestos on inventario.Id equals imagenEnBD.IdRepuesto 
                                              select new RepuestoDto
                                              {
                                                  Id = inventario.Id,
                                                  FechaDeRegistro = inventario.FechaDeRegistro.ToString(),
                                                  FechaDeModificacion = inventario.FechaDeModificacion.ToString(),
                                                  Anio = inventario.Anio,
                                                  Cantidad = inventario.Cantidad,
                                                  CodigoDelRepuesto = inventario.CodigoDelRepuesto,
                                                  MarcaDelRepuesto = inventario.MarcaDelRepuesto,
                                                  Estado = inventario.Estado,
                                                  Modelo = inventario.Modelo,
                                                  NombreDeArchivo = inventario.NombreDelRepuesto,
                                                  NombreDelRepuesto = inventario.NombreDelRepuesto,
                                                  Vehiculo = inventario.Vehiculo,
                                                  //Base64Imagen = imagenEnBD.Adjunto
                                              }).ToList();
            return losRepuestos;
        }
    }
}
