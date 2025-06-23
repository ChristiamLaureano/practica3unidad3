namespace Formulario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear(); // Limpia la lista antes de mostrar la nueva tabla

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    lstTabla.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
        }
    }
}
