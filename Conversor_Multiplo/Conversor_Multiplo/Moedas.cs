using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Conversor_Multiplo
{
    public partial class Moedas : Form
    {
        public Moedas()
        {
            InitializeComponent();
        }
        private double ObterTaxaCambio(string moeda)
        {
            switch (moeda)
            {
                case "Dólar americano": return 1.14;
                case "Euro": return 0.876;
                case "Libra Esterlina": return 0.847;
                case "Franco suíço": return 0.939;
                case "Iene": return 145;
                case "Real": return 6.36;
                case "Peso mexicano": return 21.78;
                case "Coroa sueca": return 10.95;
                default:
                    MessageBox.Show("Moeda inválida: " + moeda);
                    return -1;
            }
        }
        private void btConverter_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbValor.Text, out double valorOriginal))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            string moedaOrigem = cbMoedaAtual.SelectedItem?.ToString();
            string moedaDestino = cbMoedaDestino.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(moedaOrigem) || string.IsNullOrEmpty(moedaDestino))
            {
                MessageBox.Show("Por favor, selecione ambas as moedas.");
                return;
            }

            double taxaOrigem = ObterTaxaCambio(moedaOrigem);
            double taxaDestino = ObterTaxaCambio(moedaDestino);

            if (taxaOrigem <= 0 || taxaDestino <= 0)
            {
                MessageBox.Show("Erro ao obter taxas de câmbio.");
                return;
            }

            double valorConvertido = valorOriginal * (taxaDestino / taxaOrigem);
            lbResultado.Text = $"Resultado: {valorConvertido:F2} {moedaDestino}";
        }
    }
}
