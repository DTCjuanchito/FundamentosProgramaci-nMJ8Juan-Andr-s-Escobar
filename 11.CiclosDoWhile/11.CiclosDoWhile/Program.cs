using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CiclosDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador; //acumulador=acumulador+contador
                contador++;

            } while (contador <= 5);
            Console.WriteLine($"La suma de los cinco primero números enteros es :{acumulador}");*/
            /*int numero;
            string respuesta;

           int contador = 1;

           do
            {

                Console.WriteLine("ingrese el numero que desee multiplicar");
                numero = int.Parse(Console.ReadLine());
               do
               {

                   Console.WriteLine($"{numero}x{contador}={numero * contador}");
                   contador++;
               } while (contador <= 10);


               contador = 0;

               Console.WriteLine("¿Desea continuar multiplicando con otro numero? Escriba SI O NO");
                respuesta=Console.ReadLine();
            }while(respuesta=="si");


*/


                Console.WriteLine("Números primos del 1 al 100:");

                for (int numero = 2; numero <= 100; numero++)
                {
                    bool primo = true;

                    for (int divisor = 2; divisor < numero; divisor++)
                    {
                        if (numero % divisor == 0)
                        {
                            primo = false;
                            break;
                        }
                    }

                    if (primo)
                    {
                        Console.WriteLine(numero);
                    }
                }

                Console.ReadKey();
            }
        }
    }

