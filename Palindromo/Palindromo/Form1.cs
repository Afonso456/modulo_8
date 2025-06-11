namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_splash f = new F_splash();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verificarpalindromo();
        }
        void verificarpalindromo()
        {
            string palavra = textBox1.Text.ToLower().Trim();
            string palavrainvertida = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                palavrainvertida = palavra[i] + palavrainvertida;
                if (palavrainvertida == palavra)
                    lbMensagem.Text = "A palavra é um palindromo";
                else
                    lbMensagem.Text = "A palavra não é um palindromo";
            }

        }
    }
}
