using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoPractico1_JoseDavidVargas.UI.Controllers
{
    public class FlotaAdministrativaController : Controller
    {
        IFlotaAdministrativaLN _flotaVehiculos;        
        public FlotaAdministrativaController()
        {
            _flotaVehiculos = new FlotaAdministrativaLN();


		}
        
        // GET: FlotaAdministrativa
        public ActionResult Index()
        {            
            List<FlotaAdministrativaDto> laListaDeVehiculos = _flotaVehiculos.Listar();
            return View(laListaDeVehiculos);            
        }

        // GET: FlotaAdministrativa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlotaAdministrativa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlotaAdministrativa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        //    public async Task<ActionResult> Create(FlotaAdministrativaDto vehiculo)
        //{
        //    try
        //    {
                
        //                await _crearRepuestoLN.Guardar(repuesto);
        //                return RedirectToAction("Index");
        //            }
        //            catch
        //            {
        //                return View();
        //            }
        //        }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FlotaAdministrativa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlotaAdministrativa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FlotaAdministrativa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlotaAdministrativa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
