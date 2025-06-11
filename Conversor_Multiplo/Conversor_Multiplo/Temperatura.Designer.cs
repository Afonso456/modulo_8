namespace Conversor_Multiplo
{
    partial class Temperatura
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
            cbValorAtual = new ComboBox();
            cbUnidades = new ComboBox();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(315, 41);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 20;
            label2.Text = "Unidade a Converter";
            // 
            // label1
            // 
            label1.Location = new Point(315, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 21;
            label1.Text = "Unidade Atual\r\n\r\n";
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(12, 106);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(297, 70);
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
            // cbValorAtual
            // 
            cbValorAtual.AllowDrop = true;
            cbValorAtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValorAtual.FormattingEnabled = true;
            cbValorAtual.ImeMode = ImeMode.NoControl;
            cbValorAtual.Items.AddRange(new object[] { "Celsius", "Fahrenheit" });
            cbValorAtual.Location = new Point(161, 12);
            cbValorAtual.Name = "cbValorAtual";
            cbValorAtual.Size = new Size(148, 23);
            cbValorAtual.TabIndex = 17;
            // 
            // cbUnidades
            // 
            cbUnidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidades.FormattingEnabled = true;
            cbUnidades.Items.AddRange(new object[] { "Celsius", "Fahrenheit" });
            cbUnidades.Location = new Point(161, 41);
            cbUnidades.Name = "cbUnidades";
            cbUnidades.Size = new Size(148, 23);
            cbUnidades.TabIndex = 18;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(12, 12);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(130, 23);
            tbValor.TabIndex = 16;
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 188);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbResultado);
            Controls.Add(btConverter);
            Controls.Add(cbValorAtual);
            Controls.Add(cbUnidades);
            Controls.Add(tbValor);
            Name = "Temperatura";
            Text = "Temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label lbResultado;
        private Button btConverter;
        private ComboBox cbValorAtual;
        private ComboBox cbUnidades;
        private TextBox tbValor;
    }
}