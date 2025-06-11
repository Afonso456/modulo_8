namespace Conversor_Multiplo
{
    partial class Moedas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            lbResultado = new Label();
            btConverter = new Button();
            cbMoedaAtual = new ComboBox();
            cbMoedaDestino = new ComboBox();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(342, 41);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 20;
            label2.Text = "Unidade a Converter";
            // 
            // label1
            // 
            label1.Location = new Point(342, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 21;
            label1.Text = "Unidade Atual\r\n\r\n";
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(12, 106);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(285, 60);
            lbResultado.TabIndex = 22;
            // 
            // btConverter
            // 
            btConverter.Location = new Point(12, 54);
            btConverter.Name = "btConverter";
            btConverter.Size = new Size(115, 31);
            btConverter.TabIndex = 19;
            btConverter.Text = "Converter";
            btConverter.UseVisualStyleBackColor = true;
            btConverter.Click += btConverter_Click;
            // 
            // cbMoedaAtual
            // 
            cbMoedaAtual.AllowDrop = true;
            cbMoedaAtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMoedaAtual.FormattingEnabled = true;
            cbMoedaAtual.ImeMode = ImeMode.NoControl;
            cbMoedaAtual.Items.AddRange(new object[] { "Dólar americano", "Euro", "Iene", "Libra Esterlina", "Franco suíço", "Real", "Peso mexicano", "Coroa sueca" });
            cbMoedaAtual.Location = new Point(154, 12);
            cbMoedaAtual.Name = "cbMoedaAtual";
            cbMoedaAtual.Size = new Size(175, 23);
            cbMoedaAtual.TabIndex = 17;
            // 
            // cbMoedaDestino
            // 
            cbMoedaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMoedaDestino.FormattingEnabled = true;
            cbMoedaDestino.Items.AddRange(new object[] { "Dólar americano", "Euro", "Iene", "Libra Esterlina", "Franco suíço", "Real", "Peso mexicano", "Coroa sueca" });
            cbMoedaDestino.Location = new Point(154, 41);
            cbMoedaDestino.Name = "cbMoedaDestino";
            cbMoedaDestino.Size = new Size(175, 23);
            cbMoedaDestino.TabIndex = 18;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(12, 12);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(130, 23);
            tbValor.TabIndex = 16;
            // 
            // Moedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 179);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbResultado);
            Controls.Add(btConverter);
            Controls.Add(cbMoedaAtual);
            Controls.Add(cbMoedaDestino);
            Controls.Add(tbValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Moedas";
            Text = "Moedas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label lbResultado;
        private Button btConverter;
        private ComboBox cbMoedaAtual;
        private ComboBox cbMoedaDestino;
        private TextBox tbValor;
    }
}