using ProjetoTeste.Guilherme.UI.Services;
using System.Web.Mvc;

namespace ProjetoTeste.Guilherme.UI.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var produtos = ProdutoService.ObterProdutos();

            return View(produtos);
        }
    }
}