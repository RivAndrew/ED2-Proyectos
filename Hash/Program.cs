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
            int size = 4;   // Tamaño de la lista
            List<Lista> grafo = new List<Lista>(new Lista[size]);

            // Usando el ejemplo de la presentacion agrego a una lista de tamaño 5 el valor MUNDO con clave HOLA
            // que se asignara en el indice 2.
            Dato datoA = new Dato("HOLA", "MUNDO");
            Lista verticeA = new Lista("MUNDO");
            grafo.Insert(verticeA.FuncionHash(datoA.Clave,size), verticeA);

            // Siguiendo con el ejemplo se agrega otro valor con clave IIII que deberia realizar una colision
            // ya que ocasiona colision este nuevo valor lo relaciono con el que estaba en esa posicion.
            Dato datoB = new Dato("IIII", "NADA");
            Lista verticeB = new Lista("NADA");

            // No sé si deberiamos haber hecho un metodo que detectara colisiones, asi que ocasione una colision.
            if (verticeB.FuncionHash(datoB.Clave, size) == verticeA.FuncionHash(datoA.Clave, size)) 
            {
                verticeA.Relacionar(verticeB);
            }

            // Se agrega otro valor con indice en 4
            Dato datoC = new Dato("Estructura", "ED");
            Lista verticeC = new Lista("ED");
            grafo.Insert(verticeC.FuncionHash(datoC.Clave, size), verticeC);

            Console.ReadKey();
        }

        
    }
}
