using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatosController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public ActionResult Index()
        {
            return View();  
        }

        public ActionResult Criar()
        {
            return View();  
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }
    }
}