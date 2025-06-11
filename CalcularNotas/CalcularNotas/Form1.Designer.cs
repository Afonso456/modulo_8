namespace CalcularNotas
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
            tbNome = new TextBox();
            tbTeste = new TextBox();
            tbDesafio = new TextBox();
            tbProjeto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            lbNotaFinal = new Label();
            SuspendLayout();
            // 
            // tbNome
            // 
            tbNome.Location = new Point(315, 135);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(127, 23);
            tbNome.TabIndex = 0;
            // 
            // tbTeste
            // 
            tbTeste.Location = new Point(315, 164);
            tbTeste.Name = "tbTeste";
            tbTeste.Size = new Size(127, 23);
            tbTeste.TabIndex = 1;
            // 
            // tbDesafio
            // 
            tbDesafio.Location = new Point(315, 193);
            tbDesafio.Name = "tbDesafio";
            tbDesafio.Size = new Size(127, 23);
            tbDesafio.TabIndex = 2;
            // 
            // tbProjeto
            // 
            tbProjeto.Location = new Point(315, 222);
            tbProjeto.Name = "tbProjeto";
            tbProjeto.Size = new Size(127, 23);
            tbProjeto.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(231, 135);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.Location = new Point(231, 164);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "Teste";
            // 
            // label3
            // 
            label3.Location = new Point(231, 193);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 1;
            label3.Text = "Desafio";
            // 
            // label5
            // 
            label5.Location = new Point(231, 222);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 1;
            label5.Text = "Projeto";
            // 
            // label4
            // 
            label4.Location = new Point(448, 167);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 1;
            label4.Text = "30%";
            // 
            // label6
            // 
            label6.Location = new Point(448, 193);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 1;
            label6.Text = "30%";
            // 
            // label7
            // 
            label7.Location = new Point(448, 222);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 1;
            label7.Text = "40%";
            // 
            // button1
            // 
            button1.Location = new Point(315, 251);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular Nota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbNotaFinal
            // 
            lbNotaFinal.Location = new Point(305, 277);
            lbNotaFinal.Name = "lbNotaFinal";
            lbNotaFinal.Size = new Size(151, 37);
            lbNotaFinal.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbNotaFinal);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tbProjeto);
            Controls.Add(tbDesafio);
            Controls.Add(tbTeste);
            Controls.Add(tbNome);
            Name = "Form1";
            Text = "Calcular Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbNome;
        private TextBox tbTeste;
        private TextBox tbDesafio;
        private TextBox tbProjeto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label lbNotaFinal;
    }
}
