using AplicacaoWeb.Models.Pranchas;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers
{
    public class PranchasController : Controller
    {
        public List<PranchaModel> _Pranchas = new List<PranchaModel>() {
                new PranchaModel(){ Id = 1, Modelo = "Fish",        Litragem = 27, Altura = 5.8 },
                new PranchaModel(){ Id = 2, Modelo = "Shortboard",  Litragem = 24, Altura = 5.6 },
                new PranchaModel(){ Id = 3, Modelo = "Longboard",   Litragem = 78, Altura = 9.0 },
                new PranchaModel(){ Id = 4, Modelo = "Gun",         Litragem = 52, Altura = 7.5 },
                new PranchaModel(){ Id = 5, Modelo = "Funboard",    Litragem = 65, Altura = 7.2 },
                new PranchaModel(){ Id = 6, Modelo = "Shortboard",  Litragem = 32, Altura = 6.2 }
        };

        public IActionResult Index()
        {
            var model = new PranchasModel() { Pranchas = _Pranchas};

            return View(model);
        }
        public IActionResult Record(long id)
        {
            var pranchaAtual = _Pranchas.FirstOrDefault(prancha => prancha.Id == id);

            return View(pranchaAtual);
        }
    }
}
