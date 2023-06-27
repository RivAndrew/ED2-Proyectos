using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Dato
    {
        public string Clave { get; set; }
        public string Valor { get; set; }

        public Dato(string clave, string valor) 
        {
            Clave = clave;
            Valor = valor;   
        }

    }
}
