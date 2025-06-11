namespace Entradas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nuPessoas = new NumericUpDown();
            btEntrada = new Button();
            btSaida = new Button();
            btEstatisticas = new Button();
            lbAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbRelogio = new Label();
            ((System.ComponentModel.ISupportInitialize)nuPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 70);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Nº de Pessoas";
            // 
            // nuPessoas
            // 
            nuPessoas.Location = new Point(174, 70);
            nuPessoas.Name = "nuPessoas";
            nuPessoas.ReadOnly = true;
            nuPessoas.Size = new Size(120, 23);
            nuPessoas.TabIndex = 1;
            // 
            // btEntrada
            // 
            btEntrada.Location = new Point(69, 158);
            btEntrada.Name = "btEntrada";
            btEntrada.Size = new Size(99, 23);
            btEntrada.TabIndex = 2;
            btEntrada.Text = "Entrada";
            btEntrada.UseVisualStyleBackColor = true;
            btEntrada.Click += btEntrada_Click;
            // 
            // btSaida
            // 
            btSaida.Location = new Point(174, 158);
            btSaida.Name = "btSaida";
            btSaida.Size = new Size(99, 23);
            btSaida.TabIndex = 2;
            btSaida.Text = "Saida";
            btSaida.UseVisualStyleBackColor = true;
            btSaida.Click += btSaida_Click;
            // 
            // btEstatisticas
            // 
            btEstatisticas.Location = new Point(80, 187);
            btEstatisticas.Name = "btEstatisticas";
            btEstatisticas.Size = new Size(174, 23);
            btEstatisticas.TabIndex = 2;
            btEstatisticas.Text = "Estatisticas";
            btEstatisticas.UseVisualStyleBackColor = true;
            btEstatisticas.Click += btEstatisticas_Click;
            // 
            // lbAtual
            // 
            lbAtual.AutoSize = true;
            lbAtual.Location = new Point(69, 110);
            lbAtual.Name = "lbAtual";
            lbAtual.Size = new Size(0, 15);
            lbAtual.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.Location = new Point(12, 239);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(0, 15);
            lbRelogio.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 263);
            Controls.Add(btEstatisticas);
            Controls.Add(btSaida);
            Controls.Add(btEntrada);
            Controls.Add(nuPessoas);
            Controls.Add(lbAtual);
            Controls.Add(lbRelogio);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Entradas";
            ((System.ComponentModel.ISupportInitialize)nuPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nuPessoas;
        private Button btEntrada;
        private Button btSaida;
        private Button btEstatisticas;
        private Label lbAtual;
        private System.Windows.Forms.Timer timer1;
        private Label lbRelogio;
    }
}
