using System.Numerics;
using System.Security.AccessControl;

namespace Ejemplo
{
    internal class Program
    {

        static void QuickSort(int[] vector, int inicio, int fin)
        {
            int p = vector[inicio];
            int left = inicio+1;
            int right = fin;

            while (left<=right)
            {
                while (left<=fin && vector[left]<p) left++;
                while (right>inicio && vector[right] >= p) right--;

                if (left < right)
                    Intercambio(vector, left, right);
            }
            int idxPiv = right;
            Intercambio(vector, inicio, right);

            if (inicio < idxPiv - 1)
                QuickSort(vector, inicio, idxPiv - 1);
            if (idxPiv + 1 < fin)
                QuickSort(vector, idxPiv + 1, fin);
        }

        static void Intercambio(int[] vector, int left, int righ)
        {
            int aux = vector[left];
            vector[left] = vector[righ];
            vector[righ] = aux;
        }
        static void Main(string[] args)
        {
            int[] vector = { 3, 5, 2, 6, 7, 9, 23, 14, 20 };

            QuickSort(vector, 0, vector.Length - 1);

            for (int n = 0; n < vector.Length; n++)
            {
                Console.Write(vector[n] + " ");
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
