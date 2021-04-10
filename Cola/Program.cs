using System;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            c.Encolar(3);
            c.Encolar(4);
            c.Encolar(5);
            c.Mostrar();
            c.Desencolar();
            c.Mostrar();
            c.Desencolar();
            c.Mostrar();
            c.Desencolar();
            c.Mostrar();
            c.Desencolar();
            c.Mostrar();
        }
    }
}
