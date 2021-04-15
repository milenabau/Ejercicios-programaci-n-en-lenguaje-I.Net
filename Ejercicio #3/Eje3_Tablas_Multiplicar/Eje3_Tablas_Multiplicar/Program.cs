using System;

namespace Eje3_Tablas_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            for (int numTabla = 2; numTabla <= 9; numTabla++)//ciclo for para indicar cada tabla
            {
                Console.WriteLine("     Tabla del " + numTabla);
                for (int j = 1; j <= 10; j++)//ciclo for para calcular una tabla
                {
                    resultado = j * numTabla;
                    Console.WriteLine(+j + " x " + numTabla + " = " + resultado);
                }
            }
            Console.ReadLine();
        }
            
       
    }
}