namespace Formulario8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text.Trim();

            if (string.IsNullOrEmpty(oracion))
            {
                lblResultado.Text = "Total de palabras: 0";
                return;
            }

            int cantidadPalabras = oracion
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            lblResultado.Text = $"Total de palabras: {cantidadPalabras}";
        }
    }
}
