namespace formulario7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            if(int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin))
            {
                if (inicio < fin)
                {
                    for (int i = inicio; i <= fin; i++)
                    {
                        if (EsPrimo(i))
                        {
                            listBoxPrimos.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor de inicio debe ser menor que el valor de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

    }
}
