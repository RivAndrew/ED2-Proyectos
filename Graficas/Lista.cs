﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficas
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
    }
}
