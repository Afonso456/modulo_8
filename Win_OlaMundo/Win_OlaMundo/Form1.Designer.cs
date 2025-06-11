namespace Win_OlaMundo
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
            lbMensagem = new Label();
            button1 = new Button();
            tbNome = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(377, 177);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 15);
            lbMensagem.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(467, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Diz olá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(241, 218);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(220, 23);
            tbNome.TabIndex = 3;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(546, 218);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 518);
            Controls.Add(button2);
            Controls.Add(tbNome);
            Controls.Add(button1);
            Controls.Add(lbMensagem);
            Name = "Form1";
            Text = "Ola mundo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMensagem;
        private Button button1;
        private TextBox tbNome;
        private Button button2;
    }
}
