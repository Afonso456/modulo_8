namespace Calcular_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //butão calcular
        private void btCalcular_Click(object sender, EventArgs e)
        {
            //gaurdar os valores das textBox
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double valor3 = Convert.ToDouble(textBox3.Text);
            double valor4 = Convert.ToDouble(textBox4.Text);
            //calcular a media
            double media = (valor1 + valor2 + valor3 + valor4) / 4;
            //calcular o maior
            double maior = valor1; // assume o primeiro valor como maior
            if (valor2 > maior)
                maior = valor2;
            if (valor3 > maior)
                maior = valor3;
            if (valor4 > maior)
                maior = valor4;
            //calcular o menor valor
            double menor = valor1; // assume o primeiro valor com 
            if (valor2 < menor)
                menor = valor2;
            if (valor3 < menor)
                menor = valor3;
            if (valor4 < menor)
                menor = valor4;
            //mostrar a media, o maior e o menor na label
            lbResultados.Text = $"Media: {media:F2}\nMaior: {maior:F2}\nMenor: {menor:F2}";
            {
                
            }

        }

    }
}
