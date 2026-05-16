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

        private void AjustarFonte()
        {
            int tamanho = lblDisplay.Text.Length;

            if (tamanho <= 6)
                lblDisplay.FontSize = 70;
            
            else if (tamanho <= 10)
                lblDisplay.FontSize = 55;
            
            else if (tamanho <= 15)
                lblDisplay.FontSize = 40;
            
            else if (tamanho <= 20)
                lblDisplay.FontSize = 30;
            
            else
                lblDisplay.FontSize = 24;
        }
        private double _ultimoNumero1 = 0;
        private void OnBtnClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string texto = btn.Text;

            if ("0123456789".Contains(texto))
            {
                // Limite de 15 dígitos
                string apenasNumeros = new string(lblDisplay.Text.Where(char.IsDigit).ToArray());

                if (apenasNumeros.Length >= 15)
                    return;

                if (_acabouDeCalcular)
                {
                    lblDisplay.Text = texto;
                    AjustarFonte();
                    _acabouDeCalcular = false;
                    return;
                }

                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = texto;
                }
                
                else
                {
                    lblDisplay.Text += texto;
                }

                AjustarFonte(); 
            }
            else if (texto == "+" || texto == "−" || texto == "×" || texto == "÷")
            {
                if (lblDisplay.Text == "") return;

                _ultimoNumero1 = double.Parse(lblDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                _model.Expressao += lblDisplay.Text + texto;

                lblHistorico.Text = _model.Expressao;

                lblDisplay.Text = "";

                _digitandoSegundo = true;
            }
            else if (texto == "=")
            {
                if (lblDisplay.Text == "")
                    return;

               
                _model.Expressao += lblDisplay.Text;

                try
                {
                    double resultado = Math.Round(_model.CalcularExpressao(), 10);

                    if (double.IsNaN(resultado) || double.IsInfinity(resultado))
                    {
                        lblDisplay.Text = "Erro";
                        _model.Expressao = "";
                    }
                    else
                    {
                        if (Math.Abs(resultado) > 999999999999999)
                            lblDisplay.Text = resultado.ToString("0.#####E+0");
                        else
                            lblDisplay.Text = resultado.ToString("0.##########");

                        AjustarFonte();
                        lblHistorico.Text = _model.Expressao + " =";
                        _model.Expressao = "";
                        _acabouDeCalcular = true;
                        _digitandoSegundo = false;
                    }
                }
                catch
                {
                    lblDisplay.Text = "Erro";
                }
            }
            else if (texto == "AC")
            {
                _model = new CalculadoraModel();
                _digitandoSegundo = false;
                _acabouDeCalcular = false;
                lblDisplay.Text = "0";
                lblHistorico.Text = "";
            }
            
            else if (texto == "⌫")
            {
                if (lblDisplay.Text.Length > 1)
                    lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                else
                    lblDisplay.Text = "0";
            }
            
            else if (texto == ".")
            {
                if (!lblDisplay.Text.Contains("."))
                {
                    if (lblDisplay.Text == "" || lblDisplay.Text == "0")
                        lblDisplay.Text = "0.";
                    
                    else
                        lblDisplay.Text += ".";
                }
            }
            
            else if (texto == "%" || texto == "+/-")
            {
                if (lblDisplay.Text == "" || lblDisplay.Text == "0") return;

                double numeroAtual = double.Parse(lblDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                
                if (texto == "+/-")
                {
                    lblDisplay.Text = (numeroAtual * -1).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    _acabouDeCalcular = false;
                }

                else
                {
                    double numero2 = double.Parse(lblDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                    double porcentagem;

                    if (_digitandoSegundo)
                    {
                        porcentagem = _ultimoNumero1 * (numero2 / 100);
                    }
                    else
                    {
                        porcentagem = numero2 / 100;
                    }

                    lblDisplay.Text = Math.Round(porcentagem, 10).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    _model.Expressao = ""; // limpa a expressão!
                    _digitandoSegundo = false;
                    _acabouDeCalcular = true;
                    AjustarFonte();
                }
            }
        }
    }
}