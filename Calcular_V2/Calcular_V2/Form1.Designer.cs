namespace Calcular_V2
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
            btCalcular = new Button();
            btLimpar = new Button();
            lbResultado = new Label();
            nuNumero = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nuNumero).BeginInit();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(85, 334);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(168, 39);
            btCalcular.TabIndex = 1;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(85, 379);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(168, 39);
            btLimpar.TabIndex = 2;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(85, 190);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(168, 121);
            lbResultado.TabIndex = 2;
            // 
            // nuNumero
            // 
            nuNumero.Location = new Point(148, 143);
            nuNumero.Name = "nuNumero";
            nuNumero.Size = new Size(105, 23);
            nuNumero.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(85, 143);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 3;
            label2.Text = "Numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(label2);
            Controls.Add(nuNumero);
            Controls.Add(lbResultado);
            Controls.Add(btLimpar);
            Controls.Add(btCalcular);
            Name = "Form1";
            Text = "Calcular";
            ((System.ComponentModel.ISupportInitialize)nuNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btCalcular;
        private Button btLimpar;
        private Label lbResultado;
        private NumericUpDown nuNumero;
        private Label label2;
    }
}
