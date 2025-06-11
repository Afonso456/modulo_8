namespace Palindromo
{
    partial class F_splash
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbValor = new ProgressBar();
            lbPercentagem = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 165);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Palindromo...";
            // 
            // pbValor
            // 
            pbValor.Location = new Point(260, 206);
            pbValor.Name = "pbValor";
            pbValor.Size = new Size(219, 23);
            pbValor.TabIndex = 1;
            pbValor.Value = 15;
            // 
            // lbPercentagem
            // 
            lbPercentagem.AutoSize = true;
            lbPercentagem.Location = new Point(357, 241);
            lbPercentagem.Name = "lbPercentagem";
            lbPercentagem.Size = new Size(0, 15);
            lbPercentagem.TabIndex = 2;
            lbPercentagem.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // F_splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(lbPercentagem);
            Controls.Add(pbValor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_splash";
            Text = "F_splash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar pbValor;
        private Label lbPercentagem;
        private System.Windows.Forms.Timer timer1;
    }
}