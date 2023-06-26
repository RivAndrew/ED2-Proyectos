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
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
        }

        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                return true;
            }
            return false;
        }

        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }

        public string RecorrerLista()
        {
            if (ValidaVacio() == false)
            {
                string valores = string.Empty; 
                nodoActual = nodoInicial;   
                while (nodoActual.Siguiente != null)    
                {
                    nodoActual = nodoActual.Siguiente;
                    valores += $"{nodoActual.Valor}, ";
                }
                return valores.Remove(valores.Length - 2);
            }
            return "La lista esta vacia.";
        }

        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;  
            while (nodoActual.Siguiente != null)  
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor); 
            nodoActual.Siguiente = nuevoNodo;
        }

        public void AgregarNodoInicio(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor, nodoInicial.Siguiente); 
            nodoInicial.Siguiente = nuevoNodo;   
        }

        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false) 
            {
                Nodo nodoBusqueda = nodoInicial;    
                while (nodoBusqueda.Siguiente != null)  
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Valor == valor)   
                    {
                        return nodoBusqueda;    
                    }
                }
            }
            return null;   
        }

        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1; 
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;   
                while (nodoBusqueda.Siguiente != null) 
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    Indice++; 
                    if (Indice == indice)  
                    {
                        return nodoBusqueda;  
                    }
                }
            }
            return null;  
        }

        public Nodo BuscarAnterior(string valor)
        {
            if (ValidaVacio() == false) 
            {
                Nodo nodoBusqueda = nodoInicial; 
                while (nodoBusqueda.Siguiente != null 
                            && nodoBusqueda.Siguiente.Valor != valor)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Siguiente.Valor == valor)
                    {
                        return nodoBusqueda; 
                    }
                }
            }
            return null;   
        }

        public void BorrarNodo(string valor)
        {
            if (ValidaVacio() == false) 
            {
                nodoActual = Buscar(valor); 
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = BuscarAnterior(valor);
                    nodoAnterior.Siguiente = nodoActual.Siguiente; 
                    nodoActual.Siguiente = null; 
                }
            }
        }
    }
}