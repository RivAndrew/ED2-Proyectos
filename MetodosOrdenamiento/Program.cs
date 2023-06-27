using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[] { 9, 29, 13, 5, 22, 10, 2, 31, 19 };

            Impresion(arreglo);

            BubbleSort(arreglo);

            Console.WriteLine("\n");

            Impresion(arreglo);

            Console.ReadKey();
        }

        static void Impresion(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + ", ");
            }
        }

        static void BubbleSort(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = 0; j < arreglo.Length - i - 1; j++)    
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }
    }
}
