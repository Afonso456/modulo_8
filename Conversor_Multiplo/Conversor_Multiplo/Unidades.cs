using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Multiplo
{
    public partial class Unidades : Form
    {
        //dicionario de taxas de conversão de medidas
        public Unidades()
        {
            InitializeComponent();
        }
        private int ObterExpoenteUnidade(string unidade)
        {
            switch (unidade.ToLower())
            {
                case "quilómetro": return 3;
                case "hectómetro": return 2;
                case "decâmetro": return 1;
                case "metro": return 0;
                case "decímetro": return -1;
                case "centímetro": return -2;
                case "milímetro": return -3;
                default:
                    return 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbValor.Text, out double valor))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            string unidadeAtual = cbValorAtual.SelectedItem?.ToString().ToLower();
            string unidadeDestino = cbUnidades.SelectedItem?.ToString().ToLower();

            if (string.IsNullOrEmpty(unidadeAtual) || string.IsNullOrEmpty(unidadeDestino))
            {
                MessageBox.Show("Por favor, selecione ambas as unidades.");
                return;
            }

            int expoenteAtual = ObterExpoenteUnidade(unidadeAtual);
            int expoenteDestino = ObterExpoenteUnidade(unidadeDestino);

            int diferenca = expoenteAtual - expoenteDestino;

            double resultado = valor * Math.Pow(10, diferenca);

            lbResultado.Text = $"Resultado: {resultado:F4} {unidadeDestino}";
        }

    }
}

