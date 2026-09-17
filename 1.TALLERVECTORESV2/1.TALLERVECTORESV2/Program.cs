using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TALLERVECTORESV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] vector = new int[15];                                        1 EJERCICIO

            //llenar vector
            for (int i = 0; i < 15; i++) 
            {
                Console.WriteLine("ingrese el numero" + (i + 1) + ":");
                vector[i]=int.Parse(Console.ReadLine());
            }
            int mayor = vector[0];
            int menor = vector[0];
            for (int i = 0; i < 15; i++) 
            {
                if (vector[i]>mayor)
                {
                    mayor = vector[i];

                }
                if (vector[i] < menor)
                {
                    menor = vector[i];

                }
            }
            Console.WriteLine("el numero mayor es"+mayor);
            Console.WriteLine("el numero menor es" + menor);
            Console.ReadKey();*/
            /*
                        int tamaño;                                                        EJERCICIO 2
                        Console.WriteLine("ingrerse el tamaño de los vectores");
                        tamaño = int.Parse(Console.ReadLine());

                        int[] vector1 = new int[tamaño];
                        int[] vector2 = new int[tamaño];

                        //llenar el primer vector
                        for(int i = 0;i<tamaño;i++)
                        {
                            Console.WriteLine("ingrese el numero del vector 1 en la posicion"+i+":");
                            vector1[i] = int.Parse(Console.ReadLine());
                        }

                        //llenar el segundo vector
                        for (int i = 0; i < tamaño; i++)
                        {
                            Console.WriteLine("ingrese el numero del vector 2 en la posicion" + i + ":");
                            vector2[i] = int.Parse(Console.ReadLine());
                        }
                        int iguales = 0;

                        for (int i = 0; i < tamaño; i++)
                        {
                            if (vector1[i] == vector2[2])
                            {
                                iguales++;
                            }
                        }
                        Console.WriteLine("la cantidad de elementos iguales es:" + iguales);
                        Console.ReadLine();*/


            int tamaño;

            Console.Write("Ingrese el tamaño del vector: ");
            tamaño = int.Parse(Console.ReadLine());

            char[] vector = new char[tamaño];
            char[] invertido = new char[tamaño];

            // Llenar el vector
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingrese el caracter " + (i + 1) + ": ");
                vector[i] = char.Parse(Console.ReadLine());
            }

            // Invertir el vector
            for (int i = 0; i < tamaño; i++)
            {
                invertido[i] = vector[tamaño - 1 - i];
            }

            // Mostrar vector original
            Console.WriteLine("\nVector original:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("[" + vector[i] + "] ");
            }

            // Mostrar vector invertido
            Console.WriteLine("\n\nVector invertido:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("[" + invertido[i] + "] ");
            }

            Console.ReadKey();
        }
    }
}
