using System;

namespace Eje8_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra y te diré si es palíndroma :) ");
            String palabra = Console.ReadLine();
            if (esPalindroma(palabra)) Console.WriteLine("Es palíndroma");
            else Console.WriteLine("NO es palíndroma");
        }

        static Boolean esPalindroma(String cadena)
        {
            Console.WriteLine("Función llamada con => " + cadena);
            if (cadena.Length < 2) return true;
            Console.WriteLine("Vamos a comparar => " + cadena[0]);
            Console.WriteLine("Con => " + cadena[cadena.Length - 1]);
            if (cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
    }
    
}
