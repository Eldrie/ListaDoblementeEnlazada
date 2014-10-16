using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazada
{
    class ListaEnlazada
    {
        
        public Nodo cabeza;
        public Nodo cola;

        public ListaEnlazada()
        {
            cabeza = cola = null;
        }

        public bool vacia()
        {
            if (cabeza == null) return true; //No hay elementos
            else return false;
        }

        public void insertar(string dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (vacia())
                cabeza = cola = nuevo;
            else
            {
                cola.sig = nuevo;
                nuevo.ant = cola;
                cola = nuevo;
            }
        }

        public void recorrer()
        {
            for (Nodo n = cabeza; n != null; n = n.sig) //recorre la lista
            {
                MessageBox.Show(n.dato);
            }


        }

        public void recorrerAnt() 
        {
            for (Nodo n = cola; n != null; n = n.ant)
            {
                MessageBox.Show(n.dato);
            }
        }
        // como eliminar el Nodo            

        public void eliminar(string b) //En b tengo el dato a buscar para eliminar 
        {
            Nodo ant = null, act = cabeza;
            if (vacia())
                MessageBox.Show("Lista vacia");

            while (act != null)
            {
                if (act.dato == b)
                {
                    if (act == cabeza)
                        cabeza = cabeza.sig;
                    else
                        ant.sig = act.sig;
                    break;// para romper el while
                }
                else 
                {
                    ant = act;
                    act = act.sig;
                }
            }
        }

        public void modificar(string buscar, string reemplazo) 
        {
            Nodo act = cabeza;
            while (act != null)
            {
                if (act.dato == buscar)
                {
                    act.dato = reemplazo;
                    break;
                }
                    act = act.sig;
                }
            }
        }
    }
}
