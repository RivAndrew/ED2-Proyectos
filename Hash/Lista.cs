using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Lista
    {
        Nodo nodoInicial;

        public Lista(string dato)
        {
            nodoInicial = new Nodo(dato);
        }

        public void AgregarNodo(string valor)
        {
            Nodo nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            nodoActual.Siguiente = new Nodo(valor);
        }
        public void Relacionar(Lista vertice)
        {
            AgregarNodo(vertice.nodoInicial.Valor);
        }

        public int FuncionHash(string clave, int size)
        {
            double suma = 0;
            foreach (char caracter in clave)
            {
                suma += (int)caracter;
            }
            return (int)suma % (size + 1);
        }
    }
}
