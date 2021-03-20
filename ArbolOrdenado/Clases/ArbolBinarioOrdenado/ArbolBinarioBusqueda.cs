using ArbolOrdenado.Clases.ArbolBinarioOrdenado;
using System;

class ArbolBinarioBusqueda : ArbolBinario
{
    public ArbolBinarioBusqueda() : base()
    {

    }
    private nodo buscar(object buscando)
    {
        comparador dato;
        dato = (comparador)buscando;
        if (raiz == null)
        {
            return null;
        }
        else
        {
            return localizar(raizArbol(), dato);
        }
    }

    private nodo localizar(nodo raizSub, comparador buscado)
    {
        if (raiz == null)
        {
            return null;
        }
        else if (buscado.igualQue(raizSub.valorNodo()))
        {

            return raiz;
        }
        else if (buscado.menorQue(raizSub.valorNodo()))
        {
            return localizar(raizSub.subarbolIzquierdo(), buscado);
        }
        else
        {
            return localizar(raizSub.subarbolDerecho(), buscado);
        }

    }

    public void insertar(object valor)
    {
        comparador dato;
        dato = (comparador)valor;
        raiz = Insertar(raiz, dato);
    }

    private nodo Insertar(nodo raizSub, comparador dato)
    {
        if (raizSub == null)
        {
            raizSub = new nodo(dato);
        }
        else if (dato.menorIgualQue(raizSub.valorNodo()))
        {
            nodo iz;
            iz = Insertar(raizSub.subarbolIzquierdo(), dato);
            raizSub.ramaIzda(iz);
        }
        else if (dato.mayorQue(raizSub.valorNodo()))
        {
            nodo dr;
            dr = Insertar(raizSub.subarbolDerecho(), dato);
            raizSub.ramaDcho(dr);
        }
        return raizSub;
    }
    public void eliminar(object valor)
    {
        comparador dato;
        dato = (comparador)valor;
        raiz = eliminar(raiz, dato);
    }
    private nodo eliminar(nodo raizSub, comparador dato)
    {
        if (raizSub == null)
        {
            throw new Exception("No hay nodo para eliminar");
        }
        else if (dato.menorQue(raizSub.valorNodo()))
        {
            nodo iz;
            iz = eliminar(raizSub.subarbolIzquierdo(), dato);
            raiz.ramaIzda(iz);
        }
        else if (dato.mayorQue(raizSub.valorNodo()))
        {
            nodo dr;
            dr = eliminar(raizSub.subarbolDerecho(), dato);
            raizSub.ramaDcho(dr);
        }
        else //Nodo encontrado
        {
            nodo q;
            q = raizSub;
            if (q.subarbolIzquierdo() == null)
            {
                raizSub = q.subarbolDerecho();
            }
            else if (q.subarbolDerecho() == null)
            {
                raizSub = q.subarbolIzquierdo();

            }
            else //tiene rama ezquierda y derecha
            {
                q = reemplazar(q);
            }
            q = null;
        }
        return raizSub;
    }

    private nodo reemplazar(nodo act)
    {
        nodo a, p;
        p = act;
        a = act.subarbolIzquierdo(); //rama de nodos menores 

        while (a.subarbolDerecho() != null)
        {
            p = a;
            p.subarbolDerecho();
        }
        act.nuevoValor(a.valorNodo());
        if (p == act)
        {
            p.ramaIzda(a.subarbolIzquierdo());
        }
        else
        {
            p.ramaDcho(a.subarbolIzquierdo());
        }
        return a;


    }

}

    

