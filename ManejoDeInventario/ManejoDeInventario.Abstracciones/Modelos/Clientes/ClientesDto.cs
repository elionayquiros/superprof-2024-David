﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Modelos.Clientes
{
	public class ClientesDto
	{
		public string Identificación​ { get; set; }
		public string Nombre​ { get; set; }
		public string PrimerApellido​ { get; set; }
		public string SegundoApellido​ { get; set; }
		public string Telefono​ { get; set; }
		public string Correo​ { get; set; }
		public DateTime FechaDeRegistro​ { get; set; }
		public DateTime FechaDeModificacion​ { get; set; }
		public bool Estado { get; set; }	
	}
}
