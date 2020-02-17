using MVCWebPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebPresentationLayer.Controllers
{
    public class ClienteController : Controller
    {
       public ActionResult Cadastrar()
       {
            return View();
       }
        [HttpPost]
        public ActionResult Cadastrar(ClienteViewModel viewModel)
        {
            return View();
        }




        public ActionResult Index()
        {
            return View();
        }
    }
}