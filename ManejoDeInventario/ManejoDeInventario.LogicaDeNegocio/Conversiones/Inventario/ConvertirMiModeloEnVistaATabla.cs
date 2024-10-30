using ManejoDeInventario.Abstracciones.Interfaces.Conversiones.Inventario;
using ManejoDeInventario.Abstracciones.Interfaces.General.Fechas;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Conversiones.Inventario
{
	public class ConvertirMiModeloEnVistaATabla: IConvertirMiModeloEnVistaATabla
	{
		IFechas _fecha;
		public ConvertirMiModeloEnVistaATabla()
		{
			_fecha = new Fechas();
		}
		public Repuestos ObtenerRepuesto(RepuestoDto elRepuesto)
		{
			return new Repuestos
			{
				CodigoDelRepuesto = elRepuesto.CodigoDelRepuesto,
				Anio = elRepuesto.Anio,
				Cantidad = elRepuesto.Cantidad,
				Estado = elRepuesto.Estado,
				MarcaDelRepuesto = elRepuesto.MarcaDelRepuesto,
				Modelo = elRepuesto.Modelo,
				NombreDelRepuesto = elRepuesto.NombreDelRepuesto,
				Vehiculo = elRepuesto.Vehiculo,
				FechaDeRegistro = _fecha.ObtenerFecha(),
				FechaDeModificacion = _fecha.ObtenerFecha(),
				Id = elRepuesto.Id,
			};
		}
	}
}
