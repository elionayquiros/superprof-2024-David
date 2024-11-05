using CasoPractico1_JoseDavidVargas.Abstracciones.Interfaces.FlotaAdministrativa.Listar;
using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.Reservacion;
using CasoPractico1_JoseDavidVargas.LogicaDeNegocios.Reservacion.Listar;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CasoPractico1_JoseDavidVargas.UI.Controllers
{
    public class ReservacionController : Controller
    {
        IListarReservacionLN _listarReservacionLN;
        public ReservacionController()
        {
            _listarReservacionLN = new ListarReservacionLN();
        }
        // GET: Reservacion
        public ActionResult Index()
        {
            List<ReservacionDto> listaReservaciones = _listarReservacionLN.Listar();
            return View(listaReservaciones);
        }

        // GET: Reservacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservacion/Edit/5
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

        // GET: Reservacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservacion/Delete/5
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
