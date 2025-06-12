namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormModal form = new FormModal();

            if (form.ShowDialog() == DialogResult.OK)
            {
                lbMostrarValor.Text = $"{form.tbValor.Text}";
            }
            else
            {
                lbMostrarValor.Text = "Ingreso Cancelado";
            }

        }
    }
}