namespace Conversor_Multiplo
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            moedasToolStripMenuItem = new ToolStripMenuItem();
            medidasToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, moedasToolStripMenuItem, medidasToolStripMenuItem, temperaturaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(347, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "&Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sa&ir";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // moedasToolStripMenuItem
            // 
            moedasToolStripMenuItem.Name = "moedasToolStripMenuItem";
            moedasToolStripMenuItem.Size = new Size(61, 20);
            moedasToolStripMenuItem.Text = "M&oedas";
            moedasToolStripMenuItem.Click += moedasToolStripMenuItem_Click;
            // 
            // medidasToolStripMenuItem
            // 
            medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            medidasToolStripMenuItem.Size = new Size(64, 20);
            medidasToolStripMenuItem.Text = "M&edidas";
            medidasToolStripMenuItem.Click += medidasToolStripMenuItem_Click;
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(86, 20);
            temperaturaToolStripMenuItem.Text = "&Temperatura";
            temperaturaToolStripMenuItem.Click += temperaturaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 4;
            label1.Text = "Bem Vindo:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 38);
            label2.Name = "label2";
            label2.Size = new Size(198, 144);
            label2.TabIndex = 4;
            label2.Text = "Conversor de:\r\nMoedas\r\nMedidas\r\nTemperaturas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 206);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Conversor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem moedasToolStripMenuItem;
        private ToolStripMenuItem medidasToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}
