using System;

namespace Eje5_Ordenar_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            int auxiliar;

            Console.WriteLine("   *****************************************");
            Console.WriteLine("   ****  Ordenar Vector Forma Ascendente ***");
            Console.WriteLine("   *****************************************");

            Console.WriteLine("   Los numeros a ordenar son:");
            Console.WriteLine("   12, 50, 23, 11, 18, 35, 41, 85, 16, 45");
            Console.WriteLine("   ------------------------------------------");
            // metodo burbuja
            for (int i = 0; i < vector.Length; i++)
            {
               for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }
            Console.WriteLine("Datos ordenados");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
