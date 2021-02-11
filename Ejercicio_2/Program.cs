using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa creado por Ramces Batista Peña para contar desde el 1 al 10 ");
            int Numeros = 0;
            do
            {      
                Numeros = Numeros + 1;
                Console.WriteLine(Numeros);

            }while (Numeros < 10) ;
        }
    }
}
