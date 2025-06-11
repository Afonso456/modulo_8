namespace Tabuada
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
            cbNumero = new ComboBox();
            lbResultado = new Label();
            btMostrar = new Button();
            SuspendLayout();
            // 
            // cbNumero
            // 
            cbNumero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumero.FormattingEnabled = true;
            cbNumero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbNumero.Location = new Point(40, 99);
            cbNumero.Name = "cbNumero";
            cbNumero.Size = new Size(200, 23);
            cbNumero.TabIndex = 0;
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(40, 132);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(200, 108);
            lbResultado.TabIndex = 1;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(246, 115);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(100, 48);
            btMostrar.TabIndex = 2;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(btMostrar);
            Controls.Add(lbResultado);
            Controls.Add(cbNumero);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Tabuada";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbNumero;
        private Label lbResultado;
        private Button btMostrar;
    }
}
