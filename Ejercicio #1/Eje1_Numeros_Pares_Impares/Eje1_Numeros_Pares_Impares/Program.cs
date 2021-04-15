using System;

namespace Eje1_Numeros_Pares_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
    
                int numero = 0;

            Console.WriteLine("     **************************");
            Console.WriteLine("     *** Numero PAR e IMPAR ***");
            Console.WriteLine("     **************************");
            
            Console.WriteLine("   Por favor digite un numero entero");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero es Par");
                }
                else
                    Console.WriteLine("El numero es Impar");
                 Console.ReadKey();
                
        }
    }
}
