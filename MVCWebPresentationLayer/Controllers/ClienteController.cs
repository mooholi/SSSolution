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
        //Os Métodos Http mais populares são GET e POST.
        //Por padrão, todo hiperlink ou url digitada manualmente , efetuará uma chamada
        //ao servidor utilizando o método GET.
        //O POST é utilizado quando queremos ENVIAR dados ao servidos, então é mais comum
        //termos ele em um form com vários componentes inputs

       [HttpGet]
       public ActionResult Cadastrar()
       {
            return View();
       }

        [HttpPost]
        public ActionResult Cadastrar(ClienteInsertViewModel viewModel)
        {

            //O objeto ViewModel virá preenchido de acordo com os names dos inputs
            //do form que teve seu botão clicado
            ClienteMockBLL mockBLL = new ClienteMockBLL();
            try
            {
                //Esta linha pode lançar uma exception , logo ela 
                // deve estar entre um bloco try
                mockBLL.Cadastrar(viewModel);
                ViewBag.Sucesso = "Cliente cadastrado com sucesso!";

                //Se chegou e não deu Exception, redirecione o usuário para a página inicial! :)
                return View();
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