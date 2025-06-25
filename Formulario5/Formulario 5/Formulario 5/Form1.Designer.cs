namespace Formulario_5
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
            mtxtNumero = new MaskedTextBox();
            btnVerificarPrimo = new Button();
            SuspendLayout();
            // 
            // mtxtNumero
            // 
            mtxtNumero.Location = new Point(247, 98);
            mtxtNumero.Mask = "00000";
            mtxtNumero.Name = "mtxtNumero";
            mtxtNumero.Size = new Size(146, 23);
            mtxtNumero.TabIndex = 0;
            // 
            // btnVerificarPrimo
            // 
            btnVerificarPrimo.Location = new Point(259, 165);
            btnVerificarPrimo.Name = "btnVerificarPrimo";
            btnVerificarPrimo.Size = new Size(134, 23);
            btnVerificarPrimo.TabIndex = 1;
            btnVerificarPrimo.Text = "Verificar si es Primo";
            btnVerificarPrimo.UseVisualStyleBackColor = true;
            btnVerificarPrimo.Click += btnVerificarPrimo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificarPrimo);
            Controls.Add(mtxtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtNumero;
        private Button btnVerificarPrimo;
    }
}
