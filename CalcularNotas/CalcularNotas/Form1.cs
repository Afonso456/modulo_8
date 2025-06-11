using System.Linq.Expressions;

namespace CalcularNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //calcular nota final
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tbNome.Text;
                int teste = Convert.ToInt32(tbTeste.Text);
                int desafio = Convert.ToInt32(tbDesafio.Text);
                int projeto = Convert.ToInt32(tbProjeto.Text);
                //validação dos campos
                if (teste < 0 || teste > 20)
                {
                    MessageBox.Show("A notado teste não é valida. Deve estar entre 0 e 20.");
                    return;
                }
                if (desafio < 0 || desafio > 20)
                {
                    MessageBox.Show("A notado desafio não é valida. Deve estar entre 0 e 20.");
                    return;
                }
                if (projeto < 0 || projeto > 20)
                {
                    MessageBox.Show("A notado projeto não é valida. Deve estar entre 0 e 20.");
                    return;
                }

                //calcular a nota final
                float nota_final = (float)((teste * 0.3) + (desafio * 0.3) + (projeto * 0.4));
                //mostrar a nota final
                lbNotaFinal.Text = $"Nota Final: {nota_final}";
                //mostrar se a nota ´positiva ou negativa
                if (nota_final >= 10)
                    lbNotaFinal.Text += "\nTens Positiva";
                else
                    lbNotaFinal.Text += "\nTens Negativa";
            }catch(Exception Erro) //se ocurrer um erro dentro do try
        { MessageBox.Show(Erro.Message); }
        }
    }
}
