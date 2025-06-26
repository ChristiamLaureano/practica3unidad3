namespace Formulario8
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
            txtOracion = new TextBox();
            btnContar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 84);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese una oración:";
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(213, 76);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(411, 23);
            txtOracion.TabIndex = 1;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(249, 133);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(138, 23);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar Palabras";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(516, 102);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(108, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Total de palabras: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOracion;
        private Button btnContar;
        private Label lblResultado;
    }
}
