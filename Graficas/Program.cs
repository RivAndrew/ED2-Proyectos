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
            Lista verticeA = new Lista("a");
            Lista verticeE = new Lista("e");
            Lista verticeI = new Lista("i");
            Lista verticeO = new Lista("o");
            Lista verticeU = new Lista("u");

            verticeA.Relacionar(verticeE);
            verticeA.Relacionar(verticeI);
            grafo.Add(verticeA);

            verticeE.Relacionar(verticeO);
            grafo.Add(verticeE);

            verticeI.Relacionar(verticeU);
            grafo.Add(verticeI);

            verticeO.Relacionar(verticeI);
            grafo.Add(verticeO);

            verticeU.Relacionar(verticeA);
            verticeU.Relacionar(verticeO);
            grafo.Add(verticeU);

            Console.ReadKey();
        }
    }
}
