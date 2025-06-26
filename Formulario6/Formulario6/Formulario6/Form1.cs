namespace Formulario6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string entrada = maskedTextBox1.Text;

            if(int.TryParse(entrada, out int numero))
            {
                if (numero <= 0 )
                {
                  MessageBox.Show("El número debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (EsNumeroPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado");
                }

                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.", "Resultado");
                }


            }

            else
            {
                MessageBox.Show("Entrada no válida. Asegúrese de ingresar solo números.");
            }



        }

        private bool EsNumeroPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }
            return suma == numero;
        }
    }
}
