namespace ejercicio5
{
    public partial class Form1 : Form
    {
        int[] valores = new int[10];
        int contador = 0;
        FormModal form = new FormModal();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            tbLista.Clear();

            while (contador < 10 && form.ShowDialog() != DialogResult.Cancel)
            {
                if (form.tbValor.Text != string.Empty)
                {
                    valores[contador] = Convert.ToInt32(form.tbValor.Text);
                    contador++;
                }
                else
                {
                    break;
                }
                form.tbValor.Clear();
            }

            lbCantidadIngresados.Text = $"{contador}";


            if (contador != 0)
            {
                tbLista.Text = $"{contador} nuevos valores ingresados.";
            }
            else
            {
                tbLista.Text = "No se ingresaron valores.";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {




        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bool burbuja = rbBurbuja.Checked;
            bool biseccional = rbBiseccional.Checked;

            if (burbuja)
            {

            }


            tbLista.Text = "Listado:\r\n";
            for (int i = 0; i < contador; i++)
            {
                tbLista.Text += $"{valores[i]}\r\n";
            }
        }
    }
}
