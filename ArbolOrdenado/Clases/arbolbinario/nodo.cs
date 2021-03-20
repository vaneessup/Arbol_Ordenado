using System;
using System.Collections.Generic;
using System.Text;

    public class nodo
    {
        public object raiz;
        public nodo izquierdo;
        public nodo derecha;

        public nodo(object valor)
        {
            raiz = valor;
            izquierdo = null;
            derecha = null;
        }
        public nodo(nodo ramaIzquierda, object valor, nodo ramaDerecha)
        {
            raiz = valor;
            izquierdo = ramaIzquierda;
            derecha = ramaDerecha;
        }

        public void visitar()
        {
            Console.WriteLine(raiz + "<->");
        }
        public object valorNodo()
        {
            return raiz;
        }
        public nodo subarbolDerecho()
        {
            return derecha;
        }

        public nodo subarbolIzquierdo()
        {
            return izquierdo;
        }

        public void nuevoValor(object nv)
        {
            raiz = nv;
        }

        public void ramaIzda(nodo n)
        {
            izquierdo = n;
        }

        public void ramaDcho(nodo n)
        {
            derecha = n;
        }

    }
