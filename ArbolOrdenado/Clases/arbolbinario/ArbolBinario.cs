using System;
using System.Collections.Generic;
using System.Text;


 public class ArbolBinario
 {
    protected nodo raiz;

    public ArbolBinario()
    {
        raiz = null;
    }
    public ArbolBinario(nodo Valorraiz)
    {
        this.raiz = Valorraiz;
    }
    public nodo raizArbol()
    {
        return raiz;
    }

    bool esVacio()
    {
        return raiz == null;
    }

    public static nodo nuevoArbol(nodo ramaIzqda, object dato, nodo ramaDrcha)
    {
        return new nodo(ramaIzqda, dato, ramaDrcha);
    }
 }

