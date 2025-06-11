namespace Entradas
{
    partial class Estatisticas_v2
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
            lbMensagem.Location = new Point(42, 25);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(38, 15);
            lbMensagem.TabIndex = 0;
            lbMensagem.Text = "label1";
            // 
            // Estatisticas_v2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 147);
            Controls.Add(lbMensagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Estatisticas_v2";
            Text = "Estatisticas_v2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMensagem;
    }
}