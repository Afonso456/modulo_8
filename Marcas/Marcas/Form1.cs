namespace Marcas
{
    public partial class Form1 : Form
    {
        //array de strings
        string[] marcas = { "Audi", "BMW", "Mercedes", "Volkswagen", "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "Hyundai" };
        //array vazio com 4 posições
        //string[] teste = new string[4];
        public Form1()
        {
            InitializeComponent();
        }
        //evento é executado antes do formulario ser mostrado ao utilizador
        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar item por item
            //cbMarcas.Items.Add("Audi");
            //cbMarcas.Items.Add("BMW");
            //adicionar o array de uma vez
            //cbMarcas.Items.AddRange(marcas);
            //ou adiconar o array um de cada vez
            for (int i = 0; i < marcas.Length; i++)
            {
                cbMarcas.Items.Add(marcas[i]);
            }
            cbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        //ocorre quando é escolhida uma marca
        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarcas.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione uma marca:");
            }
            int posicao = cbMarcas.SelectedIndex;

            string marcaescolhida = cbMarcas.Text;
            //MessageBox.Show(marcaescolhida);
            //adicionar a marca a listbox
            lbEscolhidas.Items.Add(marcaescolhida);
            //remover a marca escolhida da combobox
            cbMarcas.Items.RemoveAt(posicao);

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            //caso n tenha nenhum item selecionado deve mostrar um aviso
            if(cbMarcas.SelectedIndex == 0)
            {
                MessageBox.Show("Precisa escolher pelo menos uma marca");
                return;
            }
            //remove o item selecionado
            int posicao = lbEscolhidas.SelectedIndex;
            string marca_escolhida = lbEscolhidas.Text;
            lbEscolhidas.Items.Remove(marca_escolhida);
            cbMarcas.Items.Add(marca_escolhida);
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            //remove todos os items da listbox
            lbEscolhidas.Items.Clear();
            //repõe todos os items da combobox
            for (int i = 0; i < marcas.Length; i++)
                if (cbMarcas.Items.Contains(marcas[i])==false)
                    cbMarcas.Items.Add(marcas[i]);
        }
    }
}
