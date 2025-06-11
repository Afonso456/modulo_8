namespace Imagens
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
            pbImagens = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagens).BeginInit();
            SuspendLayout();
            // 
            // pbImagens
            // 
            pbImagens.Location = new Point(12, 31);
            pbImagens.Name = "pbImagens";
            pbImagens.Size = new Size(630, 377);
            pbImagens.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImagens.TabIndex = 0;
            pbImagens.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(441, 433);
            button1.Name = "button1";
            button1.Size = new Size(201, 108);
            button1.TabIndex = 1;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._001_play_arrow;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 433);
            button2.Name = "button2";
            button2.Size = new Size(201, 108);
            button2.TabIndex = 1;
            button2.Text = "Escolher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbImagens);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Imagens";
            ((System.ComponentModel.ISupportInitialize)pbImagens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImagens;
        private Button button1;
        private Button button2;
    }
}
