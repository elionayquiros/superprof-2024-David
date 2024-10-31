using ManejoDeInventario.Abstracciones.Interfaces.Inventario.ObtenerPorId;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.ObtenerPorId;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.ObtenerPorId;

using System.Collections.Generic;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.ObtenerPorId
{
	public class ObtenerPorIdLN: IObtenerPorIdLN
	{
		IObtenerRepuestoPorIdAD _obtenerRepuestoPorIdAD;
		public ObtenerPorIdLN()
		{
			_obtenerRepuestoPorIdAD = new ObtenerRepuestoPorIdAD();
		}
		public RepuestoDto Obtener(int Id)
		{
			Repuestos elRepuestoEnBaseDeDatos = _obtenerRepuestoPorIdAD.Obtener(Id);
			RepuestoDto elRepuestoParaPresentar = ObtenerRepuesto(elRepuestoEnBaseDeDatos);
			return elRepuestoParaPresentar;
		}

		private RepuestoDto ObtenerRepuesto(Repuestos elRepuesto)
		{
			return new RepuestoDto
			{
				CodigoDelRepuesto = elRepuesto.CodigoDelRepuesto,
				Anio = elRepuesto.Anio,
				Cantidad = elRepuesto.Cantidad,
				Estado = elRepuesto.Estado,
				MarcaDelRepuesto = elRepuesto.MarcaDelRepuesto,
				Modelo = elRepuesto.Modelo,
				NombreDelRepuesto = elRepuesto.NombreDelRepuesto,
				Vehiculo = elRepuesto.Vehiculo,
				FechaDeRegistro = elRepuesto.FechaDeRegistro.ToString("dd-MM-yyyy hh:mm tt"),
				FechaDeModificacion = elRepuesto.FechaDeModificacion.ToString("dd-MM-yyyy hh:mm tt"),
				Id = elRepuesto.Id
			};
		}
	}
}
