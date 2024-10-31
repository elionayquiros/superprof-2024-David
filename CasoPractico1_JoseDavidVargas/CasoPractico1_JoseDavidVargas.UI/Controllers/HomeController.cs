using System.Web.Mvc;

namespace CasoPractico1_JoseDavidVargas.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Renta de autos de lujo.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contáctenos al whatsapp (506)88123456";

            return View();
        }
    }
}