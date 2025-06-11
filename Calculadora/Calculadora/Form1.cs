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

        //Button opera��o
        private void button10_Click(object sender, EventArgs e)
        {
            //guardar a opera��o selecionado
            Button bt = (Button)sender;
            operacao = bt.Text;
            //guardar o n� atual
            p_numero = Convert.ToSingle(tbPainel.Text);
            //limpar o painel
            tbPainel.Text = "0";
        }

        //button igual
        private void button15_Click(object sender, EventArgs e)
        {
            //guardar o n� atual
            float s_numero = Convert.ToSingle(tbPainel.Text);
            float resultado = 0;
            //verificar a opera��o
            switch (operacao)
            {
                //executar a opera��o
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
                    MessageBox.Show("Operal��o invalida");
                    break;
            }
            //limpar opera��o
            operacao = "";
            //guardar o resultado no painel e na variavel p_numero
            tbPainel.Text = resultado.ToString();
            p_numero = resultado;
        }

        //Button limpar
        private void buttonC_Click(object sender, EventArgs e)
        {
            tbPainel.Text = "0"; //Limpar o painel
            operacao = ""; //LImpar a opera��o
            p_numero = 0; //Limpar o numero anterior
        }
    }
}
