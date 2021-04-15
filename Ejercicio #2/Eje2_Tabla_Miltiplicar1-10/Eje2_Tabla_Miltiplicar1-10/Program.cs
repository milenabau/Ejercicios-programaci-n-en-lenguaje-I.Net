using System;

namespace Eje2_Tabla_Miltiplicar1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int numero = 0;
            int resultado = 0;

            Console.WriteLine("     **************************");
            Console.WriteLine("     ***Tabla de multiplicar***");
            Console.WriteLine("     **************************");

            Console.WriteLine("     Digite el nuemro de la tabla de multiplicar");
            numero = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                resultado = i * numero;
                Console.WriteLine(i + "X" + numero + "=" + resultado);
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}
