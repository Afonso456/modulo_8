namespace Conversor_Multiplo
{
    partial class Unidades
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
            lbResultado = new Label();
            cbValorAtual = new ComboBox();
            cbUnidades = new ComboBox();
            tbValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(32, 120);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(297, 70);
            lbResultado.TabIndex = 15;
            // 
            // cbValorAtual
            // 
            cbValorAtual.AllowDrop = true;
            cbValorAtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValorAtual.FormattingEnabled = true;
            cbValorAtual.ImeMode = ImeMode.NoControl;
            cbValorAtual.Items.AddRange(new object[] { "Kilometro", "Hectometro", "Decametro", "Metro", "Decimetro", "Centimetro", "Milimetro" });
            cbValorAtual.Location = new Point(181, 26);
            cbValorAtual.Name = "cbValorAtual";
            cbValorAtual.Size = new Size(148, 23);
            cbValorAtual.TabIndex = 12;
            // 
            // cbUnidades
            // 
            cbUnidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidades.FormattingEnabled = true;
            cbUnidades.Items.AddRange(new object[] { "Kilometro", "Hectometro", "Decametro", "Metro", "Decimetro", "Centimetro", "Milimetro" });
            cbUnidades.Location = new Point(181, 55);
            cbUnidades.Name = "cbUnidades";
            cbUnidades.Size = new Size(148, 23);
            cbUnidades.TabIndex = 13;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(32, 26);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(130, 23);
            tbValor.TabIndex = 11;
            // 
            // label1
            // 
            label1.Location = new Point(351, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 15;
            label1.Text = "Unidade Atual\r\n\r\n";
            // 
            // label2
            // 
            label2.Location = new Point(351, 55);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 15;
            label2.Text = "Unidade a Converter";
            // 
            // button1
            // 
            button1.Location = new Point(32, 55);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 16;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Unidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 200);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbResultado);
            Controls.Add(cbValorAtual);
            Controls.Add(cbUnidades);
            Controls.Add(tbValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unidades";
            Text = "Unidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultado;
        private ComboBox cbValorAtual;
        private ComboBox cbUnidades;
        private TextBox tbValor;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}