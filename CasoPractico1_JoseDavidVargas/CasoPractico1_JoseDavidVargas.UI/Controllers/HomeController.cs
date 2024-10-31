using CasoPractico1_JoseDavidVargas.Abstracciones.Modelos.FlotaAdministrativa;
using CasoPractico1_JoseDavidVargas.LogicaDeNegocios.FlotaAdministrativa.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoPractico1_JoseDavidVargas.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TODO: crear controller, vistas y en web.config conexión con BD
            /*var _listarVehiculos = new FlotaAdministrativaLN();
            List<FlotaAdministrativaDto> laListaDeVehiculos = _listarVehiculos.Listar();
            return View(laListaDeVehiculos);*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}