using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class f_splash : Form
    {
        public f_splash()
        {
            InitializeComponent();

        }
        //Timer => 2 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            string valor = pbProgresso.Value.ToString();
            pbProgresso.Value += 20;
            if (pbProgresso.Value == 100)
                timer1.Enabled = false;
            lbValor.Text = valor + "%";
            this.Close();
        }
    }
}
