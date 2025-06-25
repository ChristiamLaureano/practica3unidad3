namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarUnidades();
        }

        private void txtValorEntrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarUnidades()
        {
            
            string[] unidades = { "Metros", "Centimetros", "Pulgadas" };
            cbUnidadEntrada.Items.AddRange(unidades);
            cbUnidadSalida.Items.AddRange(unidades);

           
            cbUnidadEntrada.SelectedIndex = 0;
            cbUnidadSalida.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtValorEntrada.Text, out double valorEntrada))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorSalida.Text = string.Empty;
                return; 
            }

            
            if (cbUnidadEntrada.SelectedItem == null || cbUnidadSalida.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una unidad de entrada y una de salida.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorSalida.Text = string.Empty;
                return; 
            }

           
            string unidadEntrada = cbUnidadEntrada.SelectedItem!.ToString();
            string unidadSalida = cbUnidadSalida.SelectedItem!.ToString();
            double valorEnMetros = 0; 

            
            switch (unidadEntrada)
            {
                case "Metros":
                    valorEnMetros = valorEntrada;
                    break;
                case "Centimetros":
                    valorEnMetros = valorEntrada / 100.0; 
                    break;
                case "Pulgadas":
                    valorEnMetros = valorEntrada * 0.0254; 
                    break;
                default:
                    
                    MessageBox.Show("Unidad de entrada no reconocida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            double valorSalida = 0; 

            
            switch (unidadSalida)
            {
                case "Metros":
                    valorSalida = valorEnMetros;
                    break;
                case "Centimetros":
                    valorSalida = valorEnMetros * 100.0;
                    break;
                case "Pulgadas":
                    valorSalida = valorEnMetros / 0.0254;
                    break;
                default:
                    
                    MessageBox.Show("Unidad de salida no reconocida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            
            txtValorSalida.Text = valorSalida.ToString("F4");
        }

        
        private void cbUnidadEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUnidadSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
