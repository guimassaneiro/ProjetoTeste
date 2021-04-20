using ProjetoTeste.Guilherme.UI.Services;
using System.Web.Mvc;

namespace ProjetoTeste.Guilherme.UI.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            return View();
        }

        private int List<T>(string json)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição da sua página aqui.";

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult NossasLojas()
        {

            return View();
        }
    }
}