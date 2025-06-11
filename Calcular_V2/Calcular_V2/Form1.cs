namespace Calcular_V2
{
    public partial class Form1 : Form
    {
        //variaveis do formulario
        float maior = float.MaxValue, menor = float.MinValue, soma = 0, contar = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //butão calcular
        private void btCalcular_Click(object sender, EventArgs e)
        {
            //guardar os valores do numericUpdown em variaves
            float atual = (float)nuNumero.Value;
            contar++;
            soma += atual;
            float media = soma / contar;
            if (atual < menor)
                menor = atual;
            if (atual > maior)
                maior = atual;
            lbResultado.Text = $"Media: {media}\nMaior: {maior}\nMenor: {menor}";
        }
        //butão limpar
        private void btLimpar_Click(object sender, EventArgs e)
        {
            maior = menor = contar = soma = 0;
            lbResultado.Text = "";
        }
    }
}
