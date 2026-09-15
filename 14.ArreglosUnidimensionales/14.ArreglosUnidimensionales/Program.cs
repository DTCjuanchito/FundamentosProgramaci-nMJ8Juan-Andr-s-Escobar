using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];//conjunto de dato entero [], y significa un vector entero de 5 posiciones
            numeros[0] = 15;
            numeros[1] = 56;
            numeros[2] = 20;
            numeros[3] = 47;
            numeros[4] = 27;
            //numer[5]=100 ; no es posible porque la posición 6 con índice 5 no existe
            Console.WriteLine($"El dato almacenado en la posición 4 con indice 3 es :{numeros[3]}");

            float[] notas = new float[3];
            notas[0] = 3.6f;
            notas[1] = 4.3f;
            notas[2] = 5.0f;
            //otras formas de declarar o inicializar
            char[] simbolos = new char[] { '?','(','5','f' };
            bool[] valoresVerdad = { true, false, true, true, false };

            //Recorrer un vector para llenarlo de datos
            string[] nombres = new string[7];

            for (int i=0;i<7;i++)
            {
                Console.WriteLine($"Ingrese el nombre para la P{i+1}:I{i}");
                nombres[i]=Console.ReadLine();
            }

            //Recorrer el vector para recuperar los datos almacenados en el vector
            for(int i=0;i<nombres.Length;i++)
            {
                Console.Write($"{nombres[i]}|");

            }

            int[] enteros = new int[100];

            //llenar el arreglo
            for(int i=0;i<100;i++)
            {
                enteros[i] = 10;
            }
            //ller y mostrar el contenido
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"\n{enteros[i]}");
            }





        }
    }
}
