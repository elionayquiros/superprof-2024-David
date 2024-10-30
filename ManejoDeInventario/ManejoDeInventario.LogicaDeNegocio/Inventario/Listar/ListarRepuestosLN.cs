using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Listar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Listar
{
	public class ListarRepuestosLN: IListarRepuestosLN
	{
		IListarRepuestosAD _listarInventario;
		public ListarRepuestosLN()
		{
			_listarInventario = new ListarRepuestosAD();
		}
		public List<RepuestoDto> Listar()
		{
			List<RepuestoDto> laListaDeRepuestosEnBaseDeDatos = _listarInventario.Listar();
			return laListaDeRepuestosEnBaseDeDatos;
		}

	}
}
