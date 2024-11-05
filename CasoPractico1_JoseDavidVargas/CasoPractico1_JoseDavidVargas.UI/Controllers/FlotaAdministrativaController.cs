using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CasoPractico1_JoseDavidVargas.UI.Controllers
{
    public class FlotaAdministrativaController : Controller
    {
        IListarFlotaAdministrativaLN _flotaVehiculos;
        IRegistrarFlotaAdministrativaLN _registarVehiculos;
        public FlotaAdministrativaController()
        {
            _flotaVehiculos = new ListarFlotaAdministrativaLN();
            _registarVehiculos = new RegistrarFlotaAdministrativaLN();

        }
        
        // GET: FlotaAdministrativa
        public ActionResult Index()
        {            
            List<FlotaAdministrativaDto> laListaDeVehiculos = _flotaVehiculos.Listar();
            return View(laListaDeVehiculos);            
        }

        // GET: FlotaAdministrativa/History/5
        public ActionResult Histoy(int id)
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
        public async Task<ActionResult> Create(FlotaAdministrativaDto vehiculo)
        {
            try
            {
                await _registarVehiculos.Registrar(vehiculo);                          
                return RedirectToAction("Index");
            }
            catch
            { return View(); }  
            

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
