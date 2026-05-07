using Microsoft.AspNetCore.Mvc;
using calculadora.Models;

namespace calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        // nome da pagina que vai ser chamada
        public IActionResult Index()
        {
            //fala pro asp.net para mostrar a tela html pro usuario
            return View(new CalculadoraModel());
        }

        // diz que a acao so rodaa quando o usuario clicar no botao de calcular
        [HttpPost]
        //recebe os dados que o usuario digito na tela - numero1, numero2 e operador
        public IActionResult Index(CalculadoraModel model) 
        { 
            //chama o metodo model que vc escreveu - aqui comeca a conta
            model.Calcular();
            //devolve pro usuario o resultado daa conta
            return View(model);
        }
    }
}