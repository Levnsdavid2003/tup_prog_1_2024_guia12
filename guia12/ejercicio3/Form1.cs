namespace ejercicio3
{
    public partial class Form1 : Form
    {
        int elementos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormModal form = new FormModal();

            if (form.ShowDialog() == DialogResult.OK)
            {
                lsbListado.Items.Add(form.tbValor.Text);
                elementos++;
                lbCantidad.Text = $"{elementos}";
            }
        }
    }
}
