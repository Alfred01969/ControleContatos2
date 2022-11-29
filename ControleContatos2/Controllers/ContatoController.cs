using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;

namespace ControleContatos2.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
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

        public ActionResult Apagar()
        {
            return View();
        }

    }
}