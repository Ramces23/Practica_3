using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para numeros positivos");
            double Num = 0;
            double N = 0;
            Console.WriteLine("Digite su numero positivo para sumar, digite un numero negativo o cero para dejar de sumar");
            do
            {
                Num = Convert.ToDouble(Console.ReadLine());
                N = N + Num;

            } while (Num > 0);
            Console.WriteLine("La suma de los numeros digitados es: " + N);
        }
    }
}
