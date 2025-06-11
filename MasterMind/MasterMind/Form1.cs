namespace MasterMind
{
    public partial class Form1 : Form
    {
        //variavel da classe
        int[] codigo;
        public Form1()
        {
            InitializeComponent();
            codigo = GerarCodigo();
        }
        //Função que gera o codigo
        int[] GerarCodigo()
        {
            int[] numeros = new int[4];
            Random sortear = new Random();
            for (int i = 0; i < 4; i++)
            {
                //Gera um numero aleatorio de 1 a 9
                int n = sortear.Next(0,10);
                if (numeros.Contains(n))
                {
                    i -= 1;
                    continue;
                }
                numeros[i] = n;
            }
            return numeros;

        }
        //Função que testa a opção do jogador e compara com o codigo
        string Testar(int[] codigo, string tentativa)
        {
            string resposta = "";

            //esta certo no local certo
            for (int p = 0; p < 4; p++)
            {
                string letra = "";
                if (tentativa[p].ToString() == codigo[p].ToString())
                {
                    letra = "C";
                }
                //verifica se existe noutra posição
                for (int i = 0; letra == "" && i < 4; i++)
                {
                    if (codigo[i].ToString() == tentativa[p].ToString())
                    {
                        letra = "E";
                        break;
                    }
                }
                //não existe no codigo
                if (letra == "")
                    letra = "X";
                //não existe no codigo
                resposta += letra;
            }
            return resposta;
        }
        private void btVerifica_Click(object sender, EventArgs e)
        {
            //retirar da textbox a tentativa
            string tentativa = tbTentativa.Text;
            if (tentativa.Length != 4)
            {
                MessageBox.Show("Tem que indicar pelo menos 4 numeros");
                return;
            }
            //verificar se atentativa tem numeros repetidos
            for (int i = 0; i < 4; i++)
            {
                if (tentativa.IndexOf(tentativa[i]) != tentativa.LastIndexOf(tentativa[i]))
                {
                    MessageBox.Show("O codigo não tem numero repetidos");
                    return;
                }
            }
            //verificar 
            string feedback = Testar(codigo, tentativa);

            //se ganhou mostrar uma messagebox a perguntar se quer jogar novamente
            if (feedback == "CCCC")
            {
                //acertou no codigo
                DialogResult resposta = MessageBox
                    .Show("Acertou no codigo.Deseja jogar novamente.",
                    "Game over",MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {

                    codigo = GerarCodigo();
                    lbTentativas.Items.Clear();
                    tbTentativa.Clear();
                    tbTentativa.Focus();
                    return;
                }
            }

            //mostrar o feedback
            string linha = tentativa + "|" + feedback;
            //adicionar o feedback a listbox
            lbTentativas.Items.Add(linha);
            tbTentativa.Clear();
            tbTentativa.Focus();


        }
    }
}
