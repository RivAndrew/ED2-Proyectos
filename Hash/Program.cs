using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            List<Lista> grafo = new List<Lista>(new Lista[size]);

            Dato datoA = new Dato("HOLA", "MUNDO");
            Lista verticeA = new Lista("MUNDO");
            grafo.Insert(verticeA.FuncionHash(datoA.Clave,size), verticeA);

            Dato datoB = new Dato("IIII", "NADA");
            Lista verticeB = new Lista("NADA");

            if (verticeB.FuncionHash(datoB.Clave, size) == verticeA.FuncionHash(datoA.Clave, size)) 
            {
                verticeA.Relacionar(verticeB);
            }

            Dato datoC = new Dato("Estructura", "ED");
            Lista verticeC = new Lista("ED");
            grafo.Insert(verticeC.FuncionHash(datoC.Clave, size), verticeC);

            Console.ReadKey();
        }

        
    }
}
