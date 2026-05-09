using clCalculadora;
using calculadora.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calculadora.Controllers
{
    public class HomeController : Controller
    {
        //pagina inicial
        public IActionResult Index()
        {
            //ele ja entra no /Calculadora
            return RedirectToAction("Index", "Calculadora"); ;
        }

        
        //pagina de privacidade (pagina q eu nao uso)
        public IActionResult Privacy()
        {
            return View();
        }

        //quando da algum erro no asp.net ele vai chamar aqui e mostrar uma pagina de erro
        
        
        //o respondecache garante que a pagina de erro nunca fique presa no cache do navegador (sempre mostra o erro atual)
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            //o requestID e um codigo unico que indentifica qual requicisao deu erro(para debugar)
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
