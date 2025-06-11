namespace Win_OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma variavel para o nome
            string nome;

            //guardar o texto da tbNome
            nome = tbNome.Text;

            //alterar a mensagem da lbMensagem
            lbMensagem.Text = "Ola, " + nome;

            //ativar o botao para limpar
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbMensagem.Text = "";
            tbNome.Text = "";

            //desativar o botao
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNome.Text = "Antonio";
        }
    }
}
