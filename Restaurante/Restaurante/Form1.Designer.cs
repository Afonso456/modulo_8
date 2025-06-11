namespace Restaurante
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
            cbVegetariano = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbSobremesa = new RadioButton();
            rbPrato = new RadioButton();
            rbBebida = new RadioButton();
            lbPedidos = new ListBox();
            lbMenu = new ListBox();
            bt = new Button();
            SuspendLayout();
            // 
            // cbVegetariano
            // 
            cbVegetariano.Location = new Point(268, 46);
            cbVegetariano.Name = "cbVegetariano";
            cbVegetariano.Size = new Size(90, 19);
            cbVegetariano.TabIndex = 0;
            cbVegetariano.UseVisualStyleBackColor = true;
            cbVegetariano.CheckedChanged += cbVegetariano_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(178, 46);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Vegetariano";
            // 
            // label2
            // 
            label2.Location = new Point(178, 138);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobremesa";
            // 
            // label3
            // 
            label3.Location = new Point(178, 71);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Prato";
            // 
            // label4
            // 
            label4.Location = new Point(178, 105);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Bebida";
            // 
            // rbSobremesa
            // 
            rbSobremesa.Location = new Point(268, 138);
            rbSobremesa.Name = "rbSobremesa";
            rbSobremesa.Size = new Size(22, 13);
            rbSobremesa.TabIndex = 2;
            rbSobremesa.UseVisualStyleBackColor = true;
            rbSobremesa.CheckedChanged += rbSobremesa_CheckedChanged;
            // 
            // rbPrato
            // 
            rbPrato.Checked = true;
            rbPrato.Location = new Point(268, 73);
            rbPrato.Name = "rbPrato";
            rbPrato.Size = new Size(22, 13);
            rbPrato.TabIndex = 2;
            rbPrato.TabStop = true;
            rbPrato.UseVisualStyleBackColor = true;
            rbPrato.CheckedChanged += rbPrato_CheckedChanged;
            // 
            // rbBebida
            // 
            rbBebida.Location = new Point(268, 107);
            rbBebida.Name = "rbBebida";
            rbBebida.Size = new Size(22, 13);
            rbBebida.TabIndex = 2;
            rbBebida.UseVisualStyleBackColor = true;
            rbBebida.CheckedChanged += rbBebida_CheckedChanged;
            // 
            // lbPedidos
            // 
            lbPedidos.FormattingEnabled = true;
            lbPedidos.Location = new Point(12, 186);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(160, 244);
            lbPedidos.TabIndex = 3;
            // 
            // lbMenu
            // 
            lbMenu.FormattingEnabled = true;
            lbMenu.Location = new Point(301, 186);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(160, 244);
            lbMenu.TabIndex = 3;
            // 
            // bt
            // 
            bt.Location = new Point(178, 285);
            bt.Name = "bt";
            bt.Size = new Size(117, 36);
            bt.TabIndex = 4;
            bt.Text = "»»»»»»";
            bt.UseVisualStyleBackColor = true;
            bt.Click += bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(bt);
            Controls.Add(lbMenu);
            Controls.Add(lbPedidos);
            Controls.Add(rbBebida);
            Controls.Add(rbPrato);
            Controls.Add(rbSobremesa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbVegetariano);
            Name = "Form1";
            Text = "Ementa";
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cbVegetariano;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbSobremesa;
        private RadioButton rbPrato;
        private RadioButton rbBebida;
        private ListBox lbPedidos;
        private ListBox lbMenu;
        private Button bt;
    }
}
