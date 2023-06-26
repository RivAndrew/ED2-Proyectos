using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lista> grafo = new List<Lista>();
            Lista listaA = new Lista();
            Lista listaE= new Lista();
            Lista listaI = new Lista();
            Lista listaO = new Lista();
            Lista listaU = new Lista();

            listaA.AgregarNodo("a");
            listaA.AgregarNodo("e");
            listaA.AgregarNodo("i");
            grafo.Add(listaA);

            listaE.AgregarNodo("e");
            listaE.AgregarNodo("o");
            grafo.Add(listaE);

            listaI.AgregarNodo("i");
            listaI.AgregarNodo("u");
            grafo.Add(listaI);

            listaO.AgregarNodo("o");
            listaO.AgregarNodo("i");
            grafo.Add(listaO);

            listaU.AgregarNodo("u");
            listaU.AgregarNodo("a");
            listaU.AgregarNodo("o");
            grafo.Add(listaU);

            Console.WriteLine("Gráfica dirigida: ");
            for (int i = 0;i < grafo.Count; i++)
            {
                Console.WriteLine(grafo[i].RecorrerLista());
            }


            Console.ReadKey();
        }
    }
}
