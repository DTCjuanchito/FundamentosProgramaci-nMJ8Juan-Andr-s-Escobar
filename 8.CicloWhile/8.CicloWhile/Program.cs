using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo qie pida numeros positivos y los sume hasta que se ingrese un numero entero negativo.Se debe mostrar por pantalla el total de la suma de los numeros negativos
            /*
                        int sumaEnterosPositivos = 0;//acumulador
                        int numero = 0;

                        Console.WriteLine("Ingrese un número para sumar.Ingrese -1 para terminar");
                        numero=int.Parse(Console.ReadLine());

                        while (numero >= 0)
                        {
                            sumaEnterosPositivos += numero;
                            Console.WriteLine("Ingrese un número para sumar.Ingrese -1 para terminar");
                            numero = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("la suma de los numeros positivos ingresados es:" + sumaEnterosPositivos);*/


            //ejercicio de la foto 

            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;
            Console.WriteLine("ingrese la cantidad de numeros a evaluar");
            cantidadNumeros=int.Parse(Console.ReadLine());

            while(cantidadNumeros>
                contador)
            {
                contador++;
                Console.WriteLine("ingrese el número a evaluar");
                numero = int.Parse(Console.ReadLine());
                if (numero <0)
                {
                    contadorNegativos++;
                }
                else
                {
                    if (numero > 0)
                    {
                        contadorPositivos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }


                }
            }
            Console.WriteLine($"Cantidad postivios :{contadorPositivos} , cantidad negativos:{contadorNegativos}, cantidad ceros:{contadorCeros}");


    {
        
    }

         }

    }
}
