namespace Formulario2
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
            Minutos = new Label();
            txtMinutos = new TextBox();
            label1 = new Label();
            txtSegundos = new TextBox();
            btnIniciar = new Button();
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Minutos
            // 
            Minutos.AutoSize = true;
            Minutos.Location = new Point(226, 83);
            Minutos.Name = "Minutos";
            Minutos.Size = new Size(54, 15);
            Minutos.TabIndex = 0;
            Minutos.Text = "Minutos:";
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(316, 75);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(100, 23);
            txtMinutos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 122);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Segundos";
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(316, 114);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(100, 23);
            txtSegundos.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(316, 175);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(226, 175);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(34, 15);
            lblTiempo.TabIndex = 5;
            lblTiempo.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnIniciar);
            Controls.Add(txtSegundos);
            Controls.Add(label1);
            Controls.Add(txtMinutos);
            Controls.Add(Minutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Minutos;
        private TextBox txtMinutos;
        private Label label1;
        private TextBox txtSegundos;
        private Button btnIniciar;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}
