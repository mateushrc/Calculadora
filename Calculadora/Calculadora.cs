namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            if (!txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("x") && !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("÷"))
            {
                txtResultado.Text += "+";
            }
            else
            {
                if (txtResultado.Text.Contains("x"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("x", "+");
                }
                if (txtResultado.Text.Contains("÷"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("÷", "+");
                }
                if (txtResultado.Text.Contains("-"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("-", "+");
                }
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            if (!txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("x") && !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("÷"))
            {
                txtResultado.Text += "-";
            }
            else
            {
                if (txtResultado.Text.Contains("x"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("x", "-");
                }
                if (txtResultado.Text.Contains("÷"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("÷", "-");
                }
                if (txtResultado.Text.Contains("+"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("+", "-");
                }
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            if (!txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("x") && !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("÷"))
            {
                txtResultado.Text += "x";
            }
            else
            {
                if (txtResultado.Text.Contains("-"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("-", "x");
                }
                if (txtResultado.Text.Contains("÷"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("÷", "x");
                }
                if (txtResultado.Text.Contains("+"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("+", "x");
                }
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            if (!txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("x") && !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("÷"))
            {
                txtResultado.Text += "÷";
            }
            else
            {
                if (txtResultado.Text.Contains("-"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("-", "÷");
                }
                if (txtResultado.Text.Contains("x"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("x", "÷");
                }
                if (txtResultado.Text.Contains("+"))
                {
                    txtResultado.Text = txtResultado.Text.Replace("+", "÷");
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    if (txtResultado.Text.Contains("+"))
                    {
                        string[] valores = txtResultado.Text.Split('+');
                        if (valores.Length == 2) // Verifica se há dois valores para calcular a soma
                        {
                            Valor = Convert.ToDecimal(valores[0]);
                            Resultado = Valor + Convert.ToDecimal(valores[1]);
                        }
                    }
                    break;
                case Operacao.Subtracao:
                    if (txtResultado.Text.Contains("-"))
                    {
                        string[] valores = txtResultado.Text.Split('-');
                        if (valores.Length == 2) // Verifica se há dois valores para calcular a subtração
                        {
                            Valor = Convert.ToDecimal(valores[0]);
                            Resultado = Valor - Convert.ToDecimal(valores[1]);
                        }
                    }
                    break;
                case Operacao.Multiplicacao:
                    if (txtResultado.Text.Contains("x"))
                    {
                        string[] valores = txtResultado.Text.Split('x');
                        if (valores.Length == 2) // Verifica se há dois valores para calcular a multiplicação
                        {
                            Valor = Convert.ToDecimal(valores[0]);
                            Resultado = Valor * Convert.ToDecimal(valores[1]);
                        }
                    }
                    break;
                case Operacao.Divisao:
                    if (txtResultado.Text.Contains("÷"))
                    {
                        string[] valores = txtResultado.Text.Split('÷');
                        if (valores.Length == 2) // Verifica se há dois valores para calcular a divisão
                        {
                            Valor = Convert.ToDecimal(valores[0]);
                            Resultado = Valor / Convert.ToDecimal(valores[1]);
                        }
                    }
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }
    }
}
