using System;

namespace Eje4_Numero_Primo
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int divisor = 0;
            int divisores = 1;
            Console.WriteLine("************************");
            Console.WriteLine("***  NUMERO PRIMO    ***");
            Console.WriteLine("************************");

            Console.WriteLine("     digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            for (divisores = 2; divisores < numero; divisores++)
                {
                if ((numero % divisores) == 0)
                {
                    divisor = divisor + 1;
                    Console.WriteLine("El numero No es Primo");
                }
                else
                    divisor = 2;
                Console.WriteLine("El numero es Primo");
            }
                
            }
        }
    
}
