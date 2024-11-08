using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controler
{
    public class Contatos : Controller
    {
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
    }
}