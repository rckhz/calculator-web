namespace clCalculadora
{
    public class CalculadoraModel
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public string Operador { get; set; }
        public double Resultado { get; set; }

        public string Expressao { get; set; } = "";

        public void Calcular()
        {
            Resultado = Operador switch
            {
                "+" => Numero1 + Numero2,
                "-" => Numero1 - Numero2,
                "*" => Numero1 * Numero2,
                "/" => Numero2 != 0 ? Numero1 / Numero2 : double.NaN,
                _ => 0
            };

            FoiCalculado = true;
        }

        public string TipoCalculo { get; set; } = "normal";
        public bool FoiCalculado { get; set; } = false;

        public void CalcularEspecial()
        {
            Resultado = TipoCalculo switch
            {
                "porcentagem" => Numero1 * (Numero2 / 100),
                "quadrado" => Math.Pow(Numero1, 2),
                "raiz" => Math.Sqrt(Numero1),
                "inverso" => Numero1 != 0 ? 1 / Numero1 : 0,
                "inverterSinal" => Numero1 * -1,
                _ => Numero1
            };

            FoiCalculado = true;
        }

        public double CalcularExpressao()
        {
            string expr = Expressao
                .Replace("×", "*")
                .Replace("÷", "/")
                .Replace("−", "-");

            Resultado = Convert.ToDouble(
                new System.Data.DataTable().Compute(expr, null)
            );

            FoiCalculado = true;

            return Resultado;
        }
    }
}