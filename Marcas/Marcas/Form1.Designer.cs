namespace Marcas
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
            components = new System.ComponentModel.Container();
            cbMarcas = new ComboBox();
            lbEscolhidas = new ListBox();
            btRemover = new Button();
            btLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(31, 89);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(239, 23);
            cbMarcas.TabIndex = 0;
            toolTip1.SetToolTip(cbMarcas, "Escola uma marca");
            cbMarcas.SelectedIndexChanged += cbMarcas_SelectedIndexChanged;
            // 
            // lbEscolhidas
            // 
            lbEscolhidas.FormattingEnabled = true;
            lbEscolhidas.Location = new Point(281, 89);
            lbEscolhidas.Name = "lbEscolhidas";
            lbEscolhidas.Size = new Size(183, 139);
            lbEscolhidas.TabIndex = 1;
            toolTip1.SetToolTip(lbEscolhidas, "Marcar escolhidas");
            // 
            // btRemover
            // 
            btRemover.Location = new Point(281, 234);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(183, 26);
            btRemover.TabIndex = 2;
            btRemover.Text = "Remover";
            toolTip1.SetToolTip(btRemover, "Remover uma marca");
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(281, 266);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(183, 26);
            btLimpar.TabIndex = 2;
            btLimpar.Text = "Limpar";
            toolTip1.SetToolTip(btLimpar, "Remove todas as marcas");
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Marcas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 60);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Escolhidos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 341);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLimpar);
            Controls.Add(btRemover);
            Controls.Add(lbEscolhidas);
            Controls.Add(cbMarcas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Marcas Favoritas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMarcas;
        private ListBox lbEscolhidas;
        private Button btRemover;
        private Button btLimpar;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
    }
}
