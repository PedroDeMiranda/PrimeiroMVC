using AplicacaoWeb.Models;
using AplicacaoWeb.Models.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace AplicacaoWeb.Controllers
{
    public class alunosController : Controller
    {
        static List<PessoaModel> _Alunos = new List<PessoaModel>(){
                new PessoaModel(){ Id = 1, Nome = "João", Turma = "C#", Situacao = 10},
                new PessoaModel(){ Id = 2, Nome = "Maria", Turma = "Java", Situacao = 20},
                new PessoaModel(){ Id = 3, Nome = "Carlos", Turma = "Java", Situacao = 10},
                new PessoaModel(){ Id = 4, Nome = "José", Turma = "C#", Situacao = 10},
                new PessoaModel(){ Id = 5, Nome = "Marcelo", Turma = "Java", Situacao = 30},
                new PessoaModel(){ Id = 6, Nome = "Vinicius", Turma = "C#", Situacao = 20}
            };

        public IActionResult Index()
        {
            var model = new PessoasModel()
            {
                Pessoas = _Alunos,
            };
            return View(model);
        }

        public ActionResult Record(long id) {

            var model = _Alunos.FirstOrDefault(aluno => aluno.Id == id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Save(PessoaModel model)
        {
            var aluno = _Alunos.FirstOrDefault(i => i.Id == model.Id);


            aluno.Nome = model.Nome;
            aluno.Turma = model.Turma;
            aluno.Situacao = model.Situacao;

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(PessoaModel model)
        {
            var aluno = _Alunos.FirstOrDefault(i => i.Id == model.Id);

            _Alunos.Remove(aluno);

            return RedirectToAction("Index");
        }
    }
}
