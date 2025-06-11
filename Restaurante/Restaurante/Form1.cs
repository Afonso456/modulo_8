namespace Restaurante
{
    public partial class Form1 : Form
    {
        //variaves globais da classe
        //propriedades
        string[] pratos = { "Feijoada", "Bife a Parmegiana", "Frango Grelhado" };
        string[] sobremesas = { "Pudim", "Torta de Limão", "Sorvete" };
        string[] bebidas = { "Coca-Cola", "Suco de Laranja", "Água" };
        string[] pratos_vegi = { "Salada Caesar", "Quinoa com Legumes", "Hambúrguer Vegano" };
        public Form1()
        {
            InitializeComponent();
        }
        void preenche_listbox(ListBox listbox, string[] opcoes)
        { 
            listbox.Items.Clear();
            listbox.Items.AddRange(opcoes);
        }

        //vegetariano
        private void cbVegetariano_CheckedChanged(object sender, EventArgs e)
        {
            preenche_listbox(lbPedidos, pratos_vegi);
        }

        //prato
        private void rbPrato_CheckedChanged(object sender, EventArgs e)
        {
            preenche_listbox(lbPedidos, pratos);
        }

        //bebida
        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            preenche_listbox(lbPedidos, bebidas);
        }


        //sobremesa
        private void rbSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            preenche_listbox(lbPedidos, sobremesas);
        }

        
        //adicionar prato
        private void bt_Click(object sender, EventArgs e)
        {

        }
    }
}
