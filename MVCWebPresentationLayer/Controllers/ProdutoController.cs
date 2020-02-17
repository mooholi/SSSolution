using MVCWebPresentationLayer.Mock;
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

        //HttpPost -> Significa que este método irá atender uma requisção 
        //feita no back-end via click do botão em um form com httppost 
        //da View Testar 
        [HttpPost]
        public ActionResult Testar(ProdutoViewModel viewModel)
        {
            //O objeto ViewModel virá preenchido de acordo com os names dos inputs
            //do form que teve seu botão clicado
            ProdutoMockBLL mockBLL = new ProdutoMockBLL();
            try
            {
                //Esta linha pode lançar uma exception , logo ela 
                // deve estar entre um bloco try
                mockBLL.Cadastrar(viewModel);

                //Se chegou e não deu Exception, redirecione o usuário para a página inicial! :)
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                //Se chegou aqui, o método Cadastrar do MockBLL deu erro :(
                ViewBag.MensagemErro = ex.Message;
                //Retorna a mesma tela que o usuário estava 

                return View();
            }


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