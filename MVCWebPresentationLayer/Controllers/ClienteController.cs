using MVCWebPresentationLayer.Mock;
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

            //O objeto ViewModel virá preenchido de acordo com os names dos inputs
            //do form que teve seu botão clicado
            ClienteMockBLL mockBLL = new ClienteMockBLL();
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




        public ActionResult Index()
        {
            return View();
        }
    }
}