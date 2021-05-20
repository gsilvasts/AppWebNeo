using AppWebNeo.Infra.Data;
using AppWebNeo.Interface;
using AppWebNeo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace AppWebNeo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IContato _contato;

        public HomeController(ApplicationDbContext dbContext, IContato contato)
        {         
            _dbContext = dbContext;
            _contato = contato;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contato = _contato.List();
            var model = from cont in contato
                        select new ContatoViewModel
                        {
                            Id = cont.Id,
                            Nome = cont.Nome,
                            Email = cont.Email,
                            Telefone = cont.Telefone,
                            Endereco = cont.Endereco,
                            Cidade = cont.Cidade
                        };

            return View(model.OrderBy(m => m.Nome).ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ContatoInputModel model)
        {
            var contato = new Contato(model.Nome, model.Email, model.Telefone, model.Endereco, model.Cidade);

            _contato.Add(contato);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
