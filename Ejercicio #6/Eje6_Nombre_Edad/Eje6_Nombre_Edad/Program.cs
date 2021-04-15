using System;

namespace Eje6_Nombre_Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nomBus;

            Console.Clear();
            ImprimirVector(edad, " Edades ");
            ImprimirVector(nombre, " Nombres ");
            Console.WriteLine("\n  Digite el nombre a buscar ");
            nomBus = Console.ReadLine();

            if (ExisteNombre(nombre, nomBus))
                Console.WriteLine(" El Usuario " + nomBus + " si existe y tiene " + edad[PosocionPersona(nombre, nomBus)] + " Anos de edad ");
            else
                Console.WriteLine(" El Usuario " + nomBus + " No existe ");
        } 
         static void ImprimirVector(Array vector, string titulo)
         {
                Console.WriteLine("\n Arreglo " + titulo);

                foreach (string elemento in vector)
                {
                    Console.Write(" [ " + elemento + " ] ");
                }
         }
        static bool ExisteNombre(Array vector, string persona)
        {
            bool existe = false;
            foreach (string elemento in vector)
            {
                if (elemento == persona)
                    existe = true;
            }
            return existe;
        }

        static int PosocionPersona(Array vector, string persona)
        {
            int indice = 0;
            int posicion = 0;
            foreach (string elemento in vector)
            {
                if (elemento == persona)
                {
                    posicion = indice;
                }
                indice++;
            }
            return posicion;
        }

    }
}

