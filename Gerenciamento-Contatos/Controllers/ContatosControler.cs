using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controler
{
    public class Contatos : Controller
    {
                public ActionResult Index()
        {
            return View();
        }

    }
}