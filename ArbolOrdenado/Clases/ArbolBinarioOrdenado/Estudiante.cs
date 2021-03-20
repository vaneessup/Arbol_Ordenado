using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolOrdenado.Clases.ArbolBinarioOrdenado
{
    class Estudiante : comparador
    {
        public String info;
        public String nombre;
        public bool igualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) == 0;
        }

        public bool mayorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) >= 0;
        }

        public bool mayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) > 0;
        }

        public bool menorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) <= 0;
        }

        public bool menorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) < 0;
        }
    }
}
