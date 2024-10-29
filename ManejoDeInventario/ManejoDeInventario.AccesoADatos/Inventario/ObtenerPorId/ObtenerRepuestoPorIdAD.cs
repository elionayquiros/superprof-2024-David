﻿using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.ObtenerPorId;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System.Linq;

namespace ManejoDeInventario.AccesoADatos.Inventario.ObtenerPorId
{
    public class ObtenerRepuestoPorIdAD : IObtenerRepuestoPorIdAD
    {
        Contexto _elContexto;
        public ObtenerRepuestoPorIdAD()
        {
            _elContexto = new Contexto();
        }
        public Repuestos Obtener(int Id)
        {
            Repuestos elRepuesto = _elContexto.Repuestos.Where(repuesto => repuesto.Id == Id).FirstOrDefault();
            return elRepuesto;
        }
    }
}
