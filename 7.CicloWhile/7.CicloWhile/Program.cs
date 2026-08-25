using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int contador = 1;
            //    int acumulador = 1;

            //    while(contador<5)
            //    {
            //        contador++;
            //        acumulador = acumulador + contador;
            //    }

            //    Console.WriteLine($"La suma de los primeros 5 números enteros positivos es {acumulador}");

            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario.(5! =1*2*3*4*5)

            int contador = 1;
            int acumulador = 1;
            while (contador < 5)
                {
                  contador++;
                   acumulador = acumulador + contador;
                }
        }
    }
}
