namespace Formulario2
{
    public partial class Form1 : Form
    {
        private int tiempoTotal;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarEtiquetaTiempo()
        {
            int minutos = tiempoTotal / 60;
            int segundos = tiempoTotal % 60;
            lblTiempo.Text = $"{minutos:D2}:{segundos:D2}";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutos.Text, out int minutos) && int.TryParse(txtSegundos.Text, out int segundos))
            {
                tiempoTotal = (minutos * 60) + segundos;

                if (tiempoTotal > 0)
                {
                    timer1.Start();
                    ActualizarEtiquetaTiempo();
                }
                else
                {
                    MessageBox.Show("El tiempo debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0)
            {
                tiempoTotal--;
                ActualizarEtiquetaTiempo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }


        }

        

    }
}
