namespace Calculadora
{
    public partial class Form1 : Form
    {
        //variaveis da classe
        string operacao;
        float p_numero;

        public Form1()
        {
            InitializeComponent();
            tbPainel.Text = "0"; //Inicializa o programa com 0
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //converter o sender num button
            Button bt = (Button)sender;
            tbPainel.Text += bt.Text;
        }

        //Button operação
        private void button10_Click(object sender, EventArgs e)
        {
            //guardar a operação selecionado
            Button bt = (Button)sender;
            operacao = bt.Text;
            //guardar o nº atual
            p_numero = Convert.ToSingle(tbPainel.Text);
            //limpar o painel
            tbPainel.Text = "0";
        }

        //button igual
        private void button15_Click(object sender, EventArgs e)
        {
            //guardar o nº atual
            float s_numero = Convert.ToSingle(tbPainel.Text);
            float resultado = 0;
            //verificar a operação
            switch (operacao)
            {
                //executar a operação
                case "+":
                    resultado = p_numero + s_numero;
                    break;
                case "-":
                    resultado = p_numero - s_numero;
                    break;
                case "*":
                    resultado = p_numero * s_numero;
                    break;
                case "/":
                    resultado = p_numero / s_numero;
                    break;
                default:
                    MessageBox.Show("Operalção invalida");
                    break;
            }
            //limpar operação
            operacao = "";
            //guardar o resultado no painel e na variavel p_numero
            tbPainel.Text = resultado.ToString();
            p_numero = resultado;
        }

        //Button limpar
        private void buttonC_Click(object sender, EventArgs e)
        {
            tbPainel.Text = "0"; //Limpar o painel
            operacao = ""; //LImpar a operação
            p_numero = 0; //Limpar o numero anterior
        }
    }
}
