using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para las letras de la Z a la A ");

            Char L;
            for (L = 'Z'; L >= 'A'; L--)
                Console.WriteLine(" [{0}]", L);
        }
    }
}
