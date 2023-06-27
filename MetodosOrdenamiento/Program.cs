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

        // BubbleSort es mover los numeros mas grandes a un extremo del arreglo, utilizando comparaciones de numeros vecinos.
        static void BubbleSort(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++) // se repiten las instrucciones de adentro el numero de elementos del arreglo menos 1 por que estamos comparando 
            {                                            // con el numero siguiente y no podemos comparar el numero final con el siguiente por que no hay nada despues.
                for (int j = 0; j < arreglo.Length - i - 1; j++) // se reptien las instrucciones de adentro el numero de elementos del arreglo menos 1 y menos i por que, 
                {                                                // si se hizo significa que el valor mas grande esta hasta la derecha y no se necesita volver a checar.
                    if (arreglo[j] > arreglo[j + 1]) // se compara si el valor actual es mayor que el siguiente valor
                    {
                        int temp = arreglo[j]; // se guarda el valor mas grande a mover en una variable temporal.
                        arreglo[j] = arreglo[j + 1]; // se guarda el valor mas chico en el espacio anterior.
                        arreglo[j + 1] = temp; // se coloca el valor mas grande a la derecha.
                    }
                }
            }
        }
    }
}
