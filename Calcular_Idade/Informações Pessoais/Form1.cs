namespace Informações_Pessoais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Função construtora do formulario
            InitializeComponent();
            //definir como datamaxima a data atual
            dtDataMes.MaxDate = DateTime.Now;

        }

        //opção sair do prgrama
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //terminar o programa
            Application.Exit();
        }
        //calular idade
        private void btCalcular_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now; //data atual
            DateTime dataNascimento = dtDataMes.Value; //data de nascimento
                
            //calcular a diferença entre a data atual e a data de nascimento
            TimeSpan tempo = dataAtual.Date - dataNascimento.Date;

            lbResultados.Text = (tempo.TotalDays / 365).ToString();

            //verificar se o ano é bisexto
            if (DateTime.IsLeapYear(dataNascimento.Year))
            {
                lbResultados.Text += "ano.\nNasceste num ano bissexto";
            }
            else
            {
                lbResultados.Text += "anos.\nNasceste num ano regular";
            }

        }
        //butão sobre o formulario
        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //abrir o formulario sobre
            F_Sobre form = new F_Sobre();
            form.ShowDialog();
        }
    }
}
