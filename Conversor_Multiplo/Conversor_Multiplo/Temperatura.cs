namespace Conversor_Multiplo
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }
        private void btConverter_Click(object sender, EventArgs e)
        {
            // verifica se o campo valor esta vazio ou não é um numero valido
            if (!double.TryParse(tbValor.Text, out double valor))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            string unidadeAtual = cbValorAtual.SelectedItem?.ToString();
            string unidadeDestino = cbUnidades.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(unidadeAtual) || string.IsNullOrEmpty(unidadeDestino))
            {
                MessageBox.Show("Por favor, selecione ambas as unidades.");
                return;
            }

            double resultado = 0;

            // conversão
            if (unidadeAtual == unidadeDestino)
            {
                resultado = valor; // mesma unidade
            }
            else if (unidadeAtual == "Celsius" && unidadeDestino == "Fahrenheit")
            {
                resultado = (valor * 9 / 5) + 32;
            }
            else if (unidadeAtual == "Fahrenheit" && unidadeDestino == "Celsius")
            {
                resultado = (valor - 32) * 5 / 9;
            }
            else
            {
                MessageBox.Show("Conversão não suportada.");
                return;
            }

            lbResultado.Text = $"Resultado: {resultado:F2} {unidadeDestino}";
        }

    }
}

