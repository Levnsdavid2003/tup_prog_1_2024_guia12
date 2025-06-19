namespace ejercicio5
{
    public partial class Form1 : Form
    {
        int[] valores = new int[10];
        int contador = 0;
        FormModal form = new FormModal();

        #region Tipos de Busqueda
        private int BusquedaSecuencial(int[] datos, int buscado)
        {
            int i = 0;
            int indice = -1;

            while ((indice == -1) && (i < datos.Length))
            {
                if (datos[i] == buscado)
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }
        private int BusquedaBiseccional(int[] datos, int buscado)
        {
            int izq, der, medio, indice = -1;
            bool encontrado = false;
            izq = 0;
            der = datos.Length - 1;

            do
            {
                medio = (izq + der) / 2;
                if (datos[medio] == buscado) encontrado = true;

                else if (datos[medio] < buscado) izq = medio + 1;

                else der = medio - 1;

            } while ((izq <= der) && (!encontrado));

            if (encontrado) indice = medio;

            return indice;
        }
        #endregion

        #region Tipos de Ordenamiento
        void Intercambiar(int[] datos, int n, int m)
        {
            int aux = datos[n];
            datos[n] = datos[m];
            datos[m] = aux;
        }
        private void OrdenamientoBurbuja(int[] datos)
        {
            int i, j;
            for (i = 0; i < datos.Length - 1; i++)
            {
                for (j = i + 1; j < datos.Length - 1; j++)
                {
                    if (datos[i] > datos[j])
                    {
                        Intercambiar(datos, i, j);
                    }
                }
            }
        }
        private void OrdenamientoQuickSort(int[] datos, int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int pivote = datos[(inicio + fin) / 2];

            do
            {
                while (datos[i] < pivote) i++;
                while (datos[j] > pivote) j--;

                if (i <= j)
                {
                    Intercambiar(datos, i, j);
                }
                i++;
                j--;

            } while (i <= j);

            if (inicio < j) OrdenamientoQuickSort(datos, inicio, j);
            if (fin > i) OrdenamientoQuickSort(datos, i, fin);

        }
        #endregion

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
            int busqueda = Convert.ToInt32(tbValor.Text);
            bool secuencial = rbSecuencial.Checked;
            bool biseccional = rbBiseccional.Checked;
            int indice = -1;

            if (secuencial) indice = BusquedaSecuencial(valores, busqueda);
            else if (biseccional) indice = BusquedaBiseccional(valores, busqueda);
            else
            {
                tbLista.Text = "Elija una opción de Tipo de Busqueda";
            }

            if (secuencial ||  biseccional)
            {
                if (indice != -1)
                {
                    tbLista.Text = $"El valor '{valores[indice]}' se encontró en índice {indice}";
                }
                else
                {
                    tbLista.Text = "No se encontró el valor en la lista o la lista no está ordenada.";
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            tbLista.Clear();
            bool burbuja = rbBurbuja.Checked;
            bool quicksort = rbQuicksort.Checked;

            if (burbuja) OrdenamientoBurbuja(valores);
            else if (quicksort) OrdenamientoQuickSort(valores, 0, contador - 1);
            else
            {
                tbLista.Text = "Elija una opción de Tipo de Ordenamiento";
            }

            if (burbuja || quicksort)
            {
                for (int i = 0; i < contador; i++)
                {
                    tbLista.Text += $"{valores[i]}\r\n";
                }
            }
            
        }

    }
}
