using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolOrdenado.Clases.ArbolBinarioOrdenado
{
    interface comparador
    {
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool menorIgualQue(object q);
        bool mayorQue(object q);
        bool mayorIgualQue(object q);
    }
}
