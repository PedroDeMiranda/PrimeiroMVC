using AplicacaoWeb.Models.Carros;
using AplicacaoWeb.Models.Pessoas;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers
{
    public class CarrosController : Controller
    {
        static List<CarroModel> _Carros = new List<CarroModel>() {
                new CarroModel(){ Id = 1, Modelo = "GOL", Placa = "FGF5F78", Ano = 1990},
                new CarroModel(){ Id = 2, Modelo = "Sandero", Placa = "RED5D45", Ano = 2000},
                new CarroModel(){ Id = 3, Modelo = "Saveiro", Placa = "HJF4R42", Ano = 2005},
                new CarroModel(){ Id = 4, Modelo = "Bora", Placa = "TJF4R42", Ano = 2010},
                new CarroModel(){ Id = 5, Modelo = "Corola", Placa = "DFF4R42", Ano = 2015},
                new CarroModel(){ Id = 6, Modelo = "Onix", Placa = "GFF4R21", Ano = 2020}
            };
        public IActionResult Index()
        {
            var model = new CarrosModel() { Carros = _Carros };

            return View(model);
        }

        public IActionResult Record(long id)
        {
            var carroAtual = _Carros.FirstOrDefault(carro => carro.Id == id);

            return View(carroAtual);
        }

        [HttpPost]
        public IActionResult Save(CarroModel model)
        {
            var carro = _Carros.FirstOrDefault(i => i.Id == model.Id);

            carro.Modelo = model.Modelo;
            carro.Placa = model.Placa;
            carro.Ano = model.Ano;

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(CarroModel model)
        {
            var carro = _Carros.FirstOrDefault(i => i.Id == model.Id);

            _Carros.Remove(carro);

            return RedirectToAction("Index");
        }
    }
}
