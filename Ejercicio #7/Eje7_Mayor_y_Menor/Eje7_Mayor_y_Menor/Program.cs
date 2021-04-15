using System;

namespace Eje7_Mayor_y_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            //int nombre = 10;
            int edadMayor = 0;
            int posicionMayor;
            int edadMenor = 1000;
            int posicionMenor;
            int indice = 0;

//------------------------------------------------------------- recorrer el arrelo 
            for (indice = 0; indice < nombre.Length; indice++)
            {
                //bucar el mayor 
                if (edad[indice] > edadMayor)
                {
                    edadMayor = edad[indice];
                    posicionMayor = indice;
                    Console.WriteLine("el mayor es"+  nombre[posicionMayor] + "y su edad es" + edad[posicionMayor]);
                }
                // buscar el menor
                if (edad[indice] < edadMenor)
                {
                    edadMenor = edad[indice];
                    posicionMenor = indice;
                    Console.WriteLine("el menor es" + nombre[posicionMenor] + "y su edad es" + edad[posicionMenor]);
                }
            }

        }
    }
}
