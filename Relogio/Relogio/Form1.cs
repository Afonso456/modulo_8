namespace Relogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Atualizar a lable do relogio
        void aualizar_relogio()
        {
            DateTime agora = DateTime.Now;
            //fromatar a hora para o formato HH:mm:ss
            lbRelogio.Text = agora.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aualizar_relogio();
        }
    }
}
