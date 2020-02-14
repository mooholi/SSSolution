using MVCWebPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebPresentationLayer.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Testar()
        {
            return View();
        }


        public ActionResult Cadastrar ()
        {
            return View();
        }
        [HttpPost]
        //Significa que o método abaixo recebe dados 

        public ActionResult Cadastrar(ProdutoViewModel viewModel)
        {

            return View();
        }



        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }
    }
}