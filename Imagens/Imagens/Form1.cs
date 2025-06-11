namespace Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Butão para carregar imagens
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos|*.*";
            //abre a jenela de selção de ficheiros
            file.ShowDialog();
            //veriifica se o utilizador escolheu um ficheiro
            if (file.FileName == "")
                return;
            //carregar a imagem selecionada
            pbImagens.Image = Image.FromFile(file.FileName);
        }
        //Butão para limpar a imagem
        private void button1_Click(object sender, EventArgs e)
        {
            pbImagens.Image = null;
        }
    }
}
