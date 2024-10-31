using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Guardar
{
	public interface IGuardarRepuestosAD
	{
		Task<int> Guardar(Repuestos elRepuestoAGuardar);
	}
}
