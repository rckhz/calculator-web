using clCalculadora;

namespace mobCalc
{
    public partial class MainPage : ContentPage
    {
        private CalculadoraModel _model = new CalculadoraModel();
        private bool _digitandoSegundo = false;
        private bool _acabouDeCalcular = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string texto = btn.Text;

            // NÚMEROS
            if ("0123456789".Contains(texto))
            {
                if (_acabouDeCalcular)
                {
                    lblDisplay.Text = texto;
                    _acabouDeCalcular = false;
                }
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = texto;
                }
                else
                {
                    lblDisplay.Text += texto;
                }
            }
            // OPERADORES
            else if (texto == "+" || texto == "−" || texto == "×" || texto == "÷")
            {
                if (lblDisplay.Text == "") return;

                if (_digitandoSegundo)
                {
                    _model.Numero2 = double.Parse(lblDisplay.Text);
                    _model.Calcular();
                    lblDisplay.Text = _model.Resultado.ToString();
                }

                _model.Numero1 = double.Parse(lblDisplay.Text);
                _model.Operador = texto == "×" ? "*" : texto == "÷" ? "/" : texto == "−" ? "-" : "+";
                _digitandoSegundo = true;
                lblHistorico.Text = _model.Numero1 + " " + texto;
                lblDisplay.Text = "";
            }
            // IGUAL
            else if (texto == "=")
            {
                // easter egg - antes do return
                if (lblDisplay.Text == "3")
                {
                    lblDisplay.Text = "blassdadada";
                    return;
                }

                if (lblDisplay.Text == "" || !_digitandoSegundo) return;

                _model.Numero2 = double.Parse(lblDisplay.Text);
                lblHistorico.Text = _model.Numero1 + " " + _model.Operador + " " + _model.Numero2 + " =";
                _model.Calcular();
                lblDisplay.Text = _model.Resultado.ToString();
                lblHistorico.Text = lblDisplay.Text; // mostra o valor exato no histórico
                _digitandoSegundo = false;
                _acabouDeCalcular = true;
                _model = new CalculadoraModel();
            }
            // LIMPAR
            else if (texto == "AC")
            {
                _model = new CalculadoraModel();
                _digitandoSegundo = false;
                _acabouDeCalcular = false;
                lblDisplay.Text = "0";
                lblHistorico.Text = "";
            }
            // BACKSPACE
            else if (texto == "⌫")
            {
                if (lblDisplay.Text.Length > 1)
                {
                    lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                }
                else
                {
                    lblDisplay.Text = "0";
                }

                if (lblHistorico.Text.Length > 0)
                {
                    lblHistorico.Text = lblHistorico.Text.Substring(0, lblHistorico.Text.Length - 1);
                }
            }
            else if (texto == ".")
            {
                if (!lblDisplay.Text.Contains("."))
                    lblDisplay.Text += ".";
            }

            else if (texto == "%" || texto == "+/-")
            {
                if (lblDisplay.Text == "0") return;

                _model.Numero1 = double.Parse(lblDisplay.Text);
                _model.TipoCalculo = texto == "%" ? "porcentagem" : "inverterSinal";
                _model.CalcularEspecial();
                lblDisplay.Text = _model.Resultado.ToString();
            }
           

        }
    }
}