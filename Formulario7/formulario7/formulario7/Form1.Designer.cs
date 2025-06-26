namespace formulario7
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
            txtInicio = new TextBox();
            label2 = new Label();
            txtFin = new TextBox();
            btnGenerar = new Button();
            listBoxPrimos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 76);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(104, 104);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 150);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 2;
            label2.Text = "Fin:";
            // 
            // txtFin
            // 
            txtFin.Location = new Point(104, 185);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(113, 243);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar primos";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.ItemHeight = 15;
            listBoxPrimos.Location = new Point(247, 104);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(120, 109);
            listBoxPrimos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPrimos);
            Controls.Add(btnGenerar);
            Controls.Add(txtFin);
            Controls.Add(label2);
            Controls.Add(txtInicio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInicio;
        private Label label2;
        private TextBox txtFin;
        private Button btnGenerar;
        private ListBox listBoxPrimos;
    }
}
