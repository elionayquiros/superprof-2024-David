﻿using ManejoDeInventario.Abstracciones.Interfaces.General.Fechas;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Crear;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Guardar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.GuardarImagen;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Guardar;
using ManejoDeInventario.AccesoADatos.Inventario.GuardarImagen;
using ManejoDeInventario.LogicaDeNegocio.General.Fechas;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Crear
{
    public class CrearRepuestoLN : ICrearRepuestoLN
    {
        IGuardarRepuestosAD _guardarRepuestosAD;
        IFechas _fecha;
        IGuardarImagenAD _guardarImagenAD;
        public CrearRepuestoLN()
        {
            _guardarRepuestosAD = new GuardarRepuestosAD();
            _fecha = new Fechas();
            _guardarImagenAD = new GuardarImagenAD();
        }
        public async Task<int> Guardar(RepuestoDto elRepuesto)
        {
            try
            {
                int seGuardoElRepuesto = await _guardarRepuestosAD.Guardar(ObtenerRepuesto(elRepuesto));
                int seGuardoLaImaagen = await GuardarAjunto(elRepuesto);
                return seGuardoElRepuesto;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private Repuestos ObtenerRepuesto(RepuestoDto elRepuesto)
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
            };
        }

        private async Task<int> GuardarAjunto(RepuestoDto repuesto)
        {
            string archivoEnBase64 = "";
            int cantidadDeImagenesGuardadas = 0;
            if (repuesto.Archivo != null && repuesto.Archivo.ContentLength > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    repuesto.Archivo.InputStream.CopyTo(memoryStream);
                    byte[] archivoDeBytes = memoryStream.ToArray();
                    archivoEnBase64 = Convert.ToBase64String(archivoDeBytes);
                }

                string objetoImagenEnJson = JsonConvert.SerializeObject(ObtenerElAdjuntoParaBaseDeDatos(archivoEnBase64));
                AdjuntosRepuestos elAdjuntoDeserealizado = JsonConvert.DeserializeObject<AdjuntosRepuestos>(objetoImagenEnJson);
                cantidadDeImagenesGuardadas = await _guardarImagenAD.Guardar(ObtenerElAdjuntoParaBaseDeDatos(archivoEnBase64));

                /*string rutaCompleta = Path.Combine(repuesto.Path, repuesto.NombreDeArchivo);
				// Crear la carpeta si no existe
				if (!Directory.Exists(repuesto.Path))
				{
					Directory.CreateDirectory(repuesto.Path);
				}
				// Guardar el archivo
				repuesto.Archivo.SaveAs(rutaCompleta);*/
            }
            return cantidadDeImagenesGuardadas;
        }

        private AdjuntosRepuestos ObtenerElAdjuntoParaBaseDeDatos(string Adjunto)
        {
            return new AdjuntosRepuestos
            {
                FechaDeRegistro = _fecha.ObtenerFecha(),
                IdRepuesto = 0,
                Adjunto = Adjunto,
            };
        }
    }
}
