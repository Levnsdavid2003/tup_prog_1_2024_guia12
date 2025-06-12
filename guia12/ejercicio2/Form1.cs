namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarValor_Click(object sender, EventArgs e)
        {
            FormModal form = new FormModal();

            if (tbValor.Text != string.Empty)
            {
                form.lbMostrarValor.Text = $"{tbValor.Text}";
            }
            else
            {
                form.lbMostrarValor.Text = "No se ingresó valor.";
            }
            form.ShowDialog();
        }
    }
}
