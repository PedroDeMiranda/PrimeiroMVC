using AplicacaoWeb.Models;
using AplicacaoWeb.Models.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace AplicacaoWeb.Controllers
{
    public class alunosController : Controller
    {
        public IActionResult Index()
        {
            var alunos = new List<PessoaModel>(){
                new PessoaModel(){ Id = 1, Nome = "João", Turma = "C#", Situacao = "Em curso"},
                new PessoaModel(){ Id = 2, Nome = "Maria", Turma = "Java", Situacao = "Em curso"},
                new PessoaModel(){ Id = 3, Nome = "Carlos", Turma = "Java", Situacao = "Em curso"},
                new PessoaModel(){ Id = 4, Nome = "José", Turma = "C#", Situacao = "Em curso"},
                new PessoaModel(){ Id = 5, Nome = "Marcelo", Turma = "Java", Situacao = "Em curso"},
                new PessoaModel(){ Id = 6, Nome = "Vinicius", Turma = "C#", Situacao = "Em curso"}
            };

            var model = new PessoasModel()
            {
                Pessoas = alunos,
            };

            return View(model);
        }
    }
}
