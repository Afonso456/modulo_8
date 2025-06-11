namespace Informações_Pessoais
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
            btCalcular = new Button();
            menuStrip1 = new MenuStrip();
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dtDataMes = new DateTimePicker();
            lbResultados = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(27, 114);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 1;
            label1.Text = "Data de Nascimento";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(27, 192);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(80, 46);
            btCalcular.TabIndex = 2;
            btCalcular.Text = "Calcular Idade";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(448, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(61, 20);
            ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click_1;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sai&r";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // dtDataMes
            // 
            dtDataMes.Location = new Point(207, 114);
            dtDataMes.MaxDate = new DateTime(2025, 6, 2, 14, 50, 46, 0);
            dtDataMes.Name = "dtDataMes";
            dtDataMes.Size = new Size(217, 23);
            dtDataMes.TabIndex = 4;
            dtDataMes.Value = new DateTime(2025, 6, 2, 0, 0, 0, 0);
            // 
            // lbResultados
            // 
            lbResultados.Location = new Point(37, 268);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(224, 143);
            lbResultados.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 450);
            Controls.Add(dtDataMes);
            Controls.Add(btCalcular);
            Controls.Add(lbResultados);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Idade";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btCalcular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DateTimePicker dtDataMes;
        private Label lbResultados;
    }
}
