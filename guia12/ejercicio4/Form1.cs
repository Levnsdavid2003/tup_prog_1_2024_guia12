namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            lsbListado.Items.Clear();

            int[] elementos = new int[10];
            int contador = 0;

            FormModal form = new FormModal();

            while (contador < 10 && form.ShowDialog() != DialogResult.Cancel)
            {
                if (form.tbValor.Text != string.Empty)
                {
                    elementos[contador] = Convert.ToInt32(form.tbValor.Text);
                    contador++;
                }
                else
                {
                    break;
                }
                form.tbValor.Clear();
            }

            for (int i = 0; i < contador; i++)
            {
                lsbListado.Items.Add(elementos[i]);
            }

            lbCantidad.Text = $"{contador}";

        }
    }
}