namespace Entradas
{
    partial class Estatisticas
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
            lbMensagem = new Label();
            SuspendLayout();
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(121, 53);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(38, 15);
            lbMensagem.TabIndex = 0;
            lbMensagem.Text = "label1";
            // 
            // Estatisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 156);
            Controls.Add(lbMensagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Estatisticas";
            Text = "Estatisticas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbMensagem;
    }
}