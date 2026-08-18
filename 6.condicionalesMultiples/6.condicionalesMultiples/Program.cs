using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.condicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales multiples
            int respuesta = 0;
            Console.WriteLine("-------------Menú-------------");
            Console.WriteLine("1. Opción 1   2. Opción 2");
            Console.WriteLine("3. Opción 3   4. Opción 4");
            Console.WriteLine("5. Opción 5");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Elija una opción del menú");
            respuesta = int.Parse(Console.ReadLine());

            switch(respuesta)
            {
                case 1:
                    Console.WriteLine("Elijio Opción 1");
                    break;
                case 2:
                    Console.WriteLine("Elijio Opción 2");
                    break;
                case 3:
                    Console.WriteLine("Elijio Opción 3");
                    break;
                case 4:
                    Console.WriteLine("Elijio Opción 4");
                    break;
                case 5:
                    Console.WriteLine("Elijio Opción 5");
                    break;
                default:
                    Console.WriteLine("Elija una opción valida");
                    break;


            }
        }
    }
}
