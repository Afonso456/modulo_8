namespace Strings
{
    partial class f_splash
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
            pbProgresso = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lbValor = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(130, 70);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "Loading . . .";
            // 
            // pbProgresso
            // 
            pbProgresso.Location = new Point(75, 113);
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Size = new Size(270, 34);
            pbProgresso.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // lbValor
            // 
            lbValor.Location = new Point(130, 162);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(128, 23);
            lbValor.TabIndex = 0;
            // 
            // f_splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 214);
            Controls.Add(pbProgresso);
            Controls.Add(lbValor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "f_splash";
            Text = "f_splash";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ProgressBar pbProgresso;
        private System.Windows.Forms.Timer timer1;
        private Label lbValor;
    }
}