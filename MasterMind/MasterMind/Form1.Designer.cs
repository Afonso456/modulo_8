namespace MasterMind
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
            label1 = new Label();
            lbCombinacao = new Label();
            tbTentativa = new TextBox();
            btVerifica = new Button();
            label2 = new Label();
            label3 = new Label();
            lbTentativas = new ListBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 0;
            label1.Text = "Tente adivinhar a combinação de numeros";
            // 
            // lbCombinacao
            // 
            lbCombinacao.AutoSize = true;
            lbCombinacao.Location = new Point(25, 76);
            lbCombinacao.Name = "lbCombinacao";
            lbCombinacao.Size = new Size(0, 15);
            lbCombinacao.TabIndex = 0;
            // 
            // tbTentativa
            // 
            tbTentativa.Location = new Point(221, 56);
            tbTentativa.Name = "tbTentativa";
            tbTentativa.Size = new Size(140, 23);
            tbTentativa.TabIndex = 1;
            // 
            // btVerifica
            // 
            btVerifica.Location = new Point(221, 96);
            btVerifica.Name = "btVerifica";
            btVerifica.Size = new Size(140, 25);
            btVerifica.TabIndex = 2;
            btVerifica.Text = "Testar";
            btVerifica.UseVisualStyleBackColor = true;
            btVerifica.Click += btVerifica_Click;
            // 
            // label2
            // 
            label2.Location = new Point(221, 135);
            label2.Name = "label2";
            label2.Size = new Size(142, 143);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 59);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 0;
            label3.Text = "****";
            // 
            // lbTentativas
            // 
            lbTentativas.FormattingEnabled = true;
            lbTentativas.Location = new Point(12, 121);
            lbTentativas.Name = "lbTentativas";
            lbTentativas.Size = new Size(167, 139);
            lbTentativas.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 59);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 0;
            label4.Text = "Combinação secreta";
            // 
            // label5
            // 
            label5.Location = new Point(12, 301);
            label5.Name = "label5";
            label5.Size = new Size(270, 51);
            label5.TabIndex = 3;
            label5.Text = "X - Nº não existe\r\nE - Nº existe mas está na posição errada\r\nC - Nº está correto  na posição certa\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 361);
            Controls.Add(lbTentativas);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btVerifica);
            Controls.Add(tbTentativa);
            Controls.Add(lbCombinacao);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbCombinacao;
        private TextBox tbTentativa;
        private Button btVerifica;
        private Label label2;
        private Label label3;
        private ListBox lbTentativas;
        private Label label4;
        private Label label5;
    }
}
