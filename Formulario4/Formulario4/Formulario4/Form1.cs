namespace Formulario4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabraOriginal = txtPalabra.Text;

            if (string.IsNullOrWhiteSpace(palabraOriginal))
            {
                MessageBox.Show("Por favor, introduce una palabra.", "Campo Vacío");
                return;
            }
            string PalabraLimpia = palabraOriginal.ToLower();

            char [] arrayCaracteres = PalabraLimpia.ToCharArray();
            Array.Reverse(arrayCaracteres);
            String palabraInvertida = new string(arrayCaracteres);

            if (PalabraLimpia == palabraInvertida)
            {

                MessageBox.Show($"La palabra '{palabraOriginal}' es un palíndromo.", "Resultado");
            }
            else
            {
                MessageBox.Show($"La palabra '{palabraOriginal}' no es un palíndromo.", "Resultado");
            }
    }
    }
}
