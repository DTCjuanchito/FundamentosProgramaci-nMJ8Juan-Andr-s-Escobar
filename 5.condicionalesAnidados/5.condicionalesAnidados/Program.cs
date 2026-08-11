using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.condicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados 
            // crear un algoritmo que lea tres numeros A,B,C y visualise en pantalla el valor mas grande. El usuario debe ingresar tres valores diferentes y ver cual numero es el mayor

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Debe ingresar 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 1 es el mayor");
                }
                else 
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }

            }
            else
            {
                if(num2>num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else 
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }

            }
        }
    }
}
