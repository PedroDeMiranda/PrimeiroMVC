using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers
{
    public class MeusDadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
