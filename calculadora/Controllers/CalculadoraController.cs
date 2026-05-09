using Microsoft.AspNetCore.Mvc;
using clCalculadora;

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
        public IActionResult Calcular(CalculadoraModel model)
        {
            //chama o metodo model que vc escreveu - aqui comeca a conta
            //manda pro model calcular
            model.Calcular();
            //devolve pro usuario o resultado daa conta
            return View("Index", model);
        }

        [HttpPost]
        //recebe os dados que o usuario digito na tela - numero1, numero2 e operador
        public IActionResult Especial(CalculadoraModel model)
        {
            //chama o metodo model que vc escreveu - aqui comeca a conta
            model.CalcularEspecial();
            //devolve pro usuario o resultado daa conta
            return View("Index", model);
        }
    }
}