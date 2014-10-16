using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazada
{
    class Nodo
    {
        public string dato; //Información
        public Nodo sig; //Enlace con el siguiente nodo
        public Nodo ant;
        public Nodo(string dato)
        {
            this.dato = dato;
            this.sig = null;
            this.ant = null;
        }

        public Nodo(string dato,Nodo sig)
        {
            this.dato = dato;
            this.sig = sig;
            this.ant = ant;
        }
    }
    }
}
