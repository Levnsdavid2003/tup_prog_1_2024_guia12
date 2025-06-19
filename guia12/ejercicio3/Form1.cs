namespace ejercicio3
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

            int contador = 0;
            int elementos = 0;

            FormModal form = new FormModal();

            while (contador < 10 && form.ShowDialog() == DialogResult.OK)
            {
                if (form.tbValor.Text != string.Empty)
                {
                    lsbListado.Items.Add(form.tbValor.Text);
                    elementos++;
                    lbCantidad.Text = $"{elementos}";
                    contador++;
                }
                else
                {
                    break;
                }
                form.tbValor.Text = string.Empty;
            }
        }
    }
}
