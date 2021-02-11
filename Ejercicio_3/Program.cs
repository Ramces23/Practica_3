using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa creado por Ramces Batista Peña para que muestre los primeros 10 números pares a partir del producto de (10 x 10)");
            for (int N = 10 * 10; N <= ((10 * 10) + 20); N += 2)
            {
              
                Console.WriteLine(" [{0}]", N);

            }
        }
    }
}
