using System.Text;

namespace Entradas
{
    public partial class Form1 : Form
    {
        //numero atual de pessoas no local
        int atual = 0;
        //maior numero de pessoas que ja entraram
        int maior = 0;
        int contar = 0;
        int soma_total = 0;
        //numero mais elevado de pessoas na loja
        int maximo_p = 0;
        public Form1()
        {
            InitializeComponent();
            lbAtual.Text = "Pessoas Atuais: 0";
        }

        //butão de entrada das pessoas
        private void btEntrada_Click(object sender, EventArgs e)
        {
            int pessoas_entrar = (int)nuPessoas.Value;
            if (atual + pessoas_entrar > 100)
            {
                MessageBox.Show("Nâo é possivel adicoinar mair pessoas. O limite é de 100 pessoas");
                return;
            }
            atual += pessoas_entrar;
            lbAtual.Text = atual.ToString();
            lbAtual.Text = $"Pessoas atuais: {atual}";
            nuPessoas.Value = 0;
            if (atual + pessoas_entrar > 100)
            {
                MessageBox.Show("Não é possivel adicionar mais pessoas. O limite é de 100 pessoas");
                return;
            }
            atual += pessoas_entrar;
            lbAtual.Text = $"Pessoas atuais: {atual}";
            nuPessoas.Value = 1;
            //verificar se é o maior numero de pessoas que ja entraram
            if (pessoas_entrar > maior)
                maior = pessoas_entrar;
            //contar e somar a entrada
            contar += 1;
            soma_total += pessoas_entrar;

            //verificar se atingiu a maior lotação
            if (atual > maximo_p)
                maximo_p = atual;
        }

        //butão de saida das pessoas
        private void btSaida_Click(object sender, EventArgs e)
        {
            int pessoas_sair = (int)nuPessoas.Value;
            if (atual - pessoas_sair < 0)
            {
                MessageBox.Show("Não é possivel remover pessoa inexistentes");
                return;
            }
            atual -= pessoas_sair;
            lbAtual.Text = atual.ToString();
            lbAtual.Text = $"Pessoas atuais: {atual}";
            nuPessoas.Value = 0;
        }

        //butão das estatisticas
        private void btEstatisticas_Click(object sender, EventArgs e)
        {
            //media de pessoas que entram
            float media = 0;
            media = (float)soma_total / contar;

            //criar um objeto do tipo
            //alterar o modifier do label para public
            //para permitir fazer alterações a partir do outro form
            Estatisticas f = new Estatisticas();

            string mensagem = $"Maior numero de pessoas que ja entraram: {maior}\n" +
                $"Numero de entradas: {contar}\n" +
                $"Soma total de pessoas que entraram: {soma_total}\n" +
                $"Maior lotação atingida: {maximo_p}\n" +
                $"Média de pessoas que entram: {media}";
            f.lbMensagem.Text = mensagem;
            f.ShowDialog();

            //segundo metodo passa a mensagem ao construtor
            Estatisticas_v2 f2 = new Estatisticas_v2(mensagem);
            f2.ShowDialog();

        }

        //Relogiodo programa
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
