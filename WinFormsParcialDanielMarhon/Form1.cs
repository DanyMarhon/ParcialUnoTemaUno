using Microsoft.VisualBasic.Devices;

namespace WinFormsParcialDanielMarhon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            double.TryParse(txtBoxAltura.Text, out double altura);
            double.TryParse(txtBoxRadio.Text, out double radio);

            double area = CalcularAreaCilindro(radio, altura);
            double volumen = CalcularVolumenCilindro(radio, altura);
            double baseCilindro = CalcularBaseCilindro(radio);

            dataGridView1.Rows.Add(area, volumen, baseCilindro);
            txtBoxAltura.Clear();
            txtBoxRadio.Clear();
        }


        private void CierroForms(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        public double CalcularAreaCilindro(double radio, double altura)
        {
            return 2 * Math.PI * radio * (radio + altura);
        }

        public double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * radio * radio * altura;
        }

        public double CalcularBaseCilindro(double radio)
        {
            return Math.PI * radio * radio;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
           txtBoxAltura.Clear();
                txtBoxRadio.Clear();
                dataGridView1.Rows.Clear();
        }
    }
}