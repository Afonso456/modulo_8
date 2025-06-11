namespace Conversor_Multiplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializar o formulario Moedas
            Moedas moedas = new Moedas();
            moedas.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializar o formulario Medidas
            Unidades medidas = new Unidades();
            medidas.ShowDialog();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializar o formulario Temperatura
            Temperatura temperatura = new Temperatura();
            temperatura.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fechar o programa
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
