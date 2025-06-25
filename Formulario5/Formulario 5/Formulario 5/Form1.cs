namespace Formulario_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarPrimo_Click(object sender, EventArgs e)
        {
            string textoNumero = mtxtNumero.Text.Trim(); 

            if (string.IsNullOrEmpty(textoNumero))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textoNumero, out int numero))
            {
                MessageBox.Show("El valor ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(EsNumeroPrimo(numero))

            {
                MessageBox.Show($"El Numero { numero} Es un numero primo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El Numero {numero} No es un numero primo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool EsNumeroPrimo(int numero)
        {
           
            if (numero <= 1)
            {
                return false;
            }

          
            if (numero == 2 || numero == 3)
            {
                return true;
            }

          
            if (numero % 2 == 0 || numero % 3 == 0)
            {
                return false;
            }

          
            for (int i = 5; i * i <= numero; i = i + 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                {
                    return false; 
                }
            }

            
            return true;
        }
    }
}
