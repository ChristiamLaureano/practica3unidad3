namespace Formulario
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
            txtValorEntrada = new TextBox();
            cbUnidadEntrada = new ComboBox();
            cbUnidadSalida = new ComboBox();
            btnConvertir = new Button();
            txtValorSalida = new TextBox();
            SuspendLayout();
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Location = new Point(92, 52);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(100, 23);
            txtValorEntrada.TabIndex = 0;
            txtValorEntrada.TextChanged += txtValorEntrada_TextChanged;
            // 
            // cbUnidadEntrada
            // 
            cbUnidadEntrada.FormattingEnabled = true;
            cbUnidadEntrada.Location = new Point(224, 52);
            cbUnidadEntrada.Name = "cbUnidadEntrada";
            cbUnidadEntrada.Size = new Size(121, 23);
            cbUnidadEntrada.TabIndex = 1;
            // 
            // cbUnidadSalida
            // 
            cbUnidadSalida.FormattingEnabled = true;
            cbUnidadSalida.Location = new Point(372, 52);
            cbUnidadSalida.Name = "cbUnidadSalida";
            cbUnidadSalida.Size = new Size(121, 23);
            cbUnidadSalida.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(312, 103);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtValorSalida
            // 
            txtValorSalida.Location = new Point(166, 103);
            txtValorSalida.Name = "txtValorSalida";
            txtValorSalida.ReadOnly = true;
            txtValorSalida.Size = new Size(100, 23);
            txtValorSalida.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValorSalida);
            Controls.Add(btnConvertir);
            Controls.Add(cbUnidadSalida);
            Controls.Add(cbUnidadEntrada);
            Controls.Add(txtValorEntrada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorEntrada;
        private ComboBox cbUnidadEntrada;
        private ComboBox cbUnidadSalida;
        private Button btnConvertir;
        private TextBox txtValorSalida;
    }
}
