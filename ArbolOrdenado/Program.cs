using ArbolOrdenado.Clases.ArbolBinarioOrdenado;
using System;

namespace ArbolOrdenado
{
    class Program
    {
        public static void pruebaOrden()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            String[] datos = {"Vanessa", "Marjori", "Yeymi", "Gregory", "Julio", "Nehemias", "Juan", "Moises"};
            Estudiante es = new Estudiante();
            foreach (var d in datos)
            {
                es.nombre = d;
                es.info = $"insertar No.{d}";
                ArBus.insertar(es);
                es = new Estudiante();
            }
            int pausa;
            pausa = 0;
        }
        static void Main(string[] args)
        {
            pruebaOrden();
        }
    }
}
