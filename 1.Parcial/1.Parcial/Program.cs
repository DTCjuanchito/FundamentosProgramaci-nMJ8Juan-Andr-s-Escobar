using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int ingrediente1;
            int ingrediente2;
            int ingrediente3;

            double precioBase;
            double iva;
            double valorIVA;
            double precioFinal;
            Console.WriteLine("¿Desea una pizza vegetariana?(si/no)");
            respuesta = Console.ReadLine();

            if (respuesta=="si") 
            {
                Console.WriteLine("La pizza sera vegetariana");
                Console.WriteLine("--------ingredientes--------");
                Console.WriteLine("1. Pimiento   2. Tofu");
                Console.WriteLine("3. Champiñones   4. Tomate");
                Console.WriteLine("5. Lechuga");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Elija tres ingredientes del menú, escriba el numero del ingrediente");

                Console.WriteLine("Elija el primer ingrediente");
                ingrediente1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija el segundo ingrediente");
                ingrediente2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija el tercer ingrediente");
                ingrediente3 = Convert.ToInt32(Console.ReadLine());

                if (ingrediente1==ingrediente2||ingrediente2==ingrediente3||ingrediente3==ingrediente1)
                {
                    Console.WriteLine("debe poner ingredientes diferentes");
                }

                else
                {
                    Console.WriteLine("Tiene diferentes ingredientes");
                    Console.WriteLine("su  pizza vegetariana tiene");
                    Console.WriteLine(ingrediente1);
                    Console.WriteLine(ingrediente2);
                    Console.WriteLine(ingrediente3);
                    if ((ingrediente1 == 1 && ingrediente2 == 2 && ingrediente3 == 3) ||
              (ingrediente1 == 1 && ingrediente2 == 3 && ingrediente3 == 2) ||
              (ingrediente1 == 2 && ingrediente2 == 1 && ingrediente3 == 3) ||
              (ingrediente1 == 2 && ingrediente2 == 3 && ingrediente3 == 1) ||
              (ingrediente1 == 3 && ingrediente2 == 1 && ingrediente3 == 2) ||
              (ingrediente1 == 3 && ingrediente2 == 2 && ingrediente3 == 1))
                    {
                        precioBase = 20000;
                        iva = 0.19;
                    }
                    // Tofu + Champiñones + Lechuga
                    else if ((ingrediente1 == 4 && ingrediente2 == 2 && ingrediente3 == 3) ||
                             (ingrediente1 == 4 && ingrediente2 == 3 && ingrediente3 == 2) ||
                             (ingrediente1 == 2 && ingrediente2 == 4 && ingrediente3 == 3) ||
                             (ingrediente1 == 2 && ingrediente2 == 3 && ingrediente3 == 4) ||
                             (ingrediente1 == 3 && ingrediente2 == 4 && ingrediente3 == 2) ||
                             (ingrediente1 == 3 && ingrediente2 == 2 && ingrediente3 == 4))
                    {
                        precioBase = 30000;
                        iva = 0.15;
                    }
                    // Cualquier otra combinación
                    else
                    {
                        precioBase = 25000;
                        iva = 0.10;
                    }

                    Console.WriteLine("Precio base: $" + precioBase);
                    Console.WriteLine("IVA: " + (iva * 100) + "%");
                    Console.WriteLine();
                    Console.WriteLine("-------- RESULTADO --------");
                    Console.WriteLine("Tipo de pizza:  vegetariana");
                    Console.WriteLine("Ingredientes: " + ingrediente1 + ", "
                                      + ingrediente2+ingrediente3);

                    Console.WriteLine("Precio base: $" + precioBase.ToString("N0"));
                    Console.WriteLine("IVA: " + iva + "%");
                    Console.WriteLine("Valor del IVA: $" + valorIVA.ToString("N0"));
                    Console.WriteLine("Precio final: $" + precioFinal.ToString("N0"));
                }
               




            }
            else
            {
                Console.WriteLine("La pizza no sera vegetariana");
         
                Console.WriteLine("--------ingredientes--------");
                Console.WriteLine("1. res  2. choriso");
                Console.WriteLine("3. pollo   4. tocineta");
                Console.WriteLine("5. cerdo");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Elija dos ingredientes del menú , escriba el numero del ingrediente");

                Console.WriteLine("Elija el primer ingrediente");
                ingrediente1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija el segundo ingrediente");
                ingrediente2 = Convert.ToInt32(Console.ReadLine());

                if (ingrediente1 == ingrediente2 )
                {
                    Console.WriteLine("debe poner ingredientes diferentes");
                }

                else
                {
                    Console.WriteLine("Tiene diferentes ingredientes");
                    Console.WriteLine("su  pizza vegetariana tiene");
                    Console.WriteLine(ingrediente1);
                    Console.WriteLine(ingrediente2);
                    if ((ingrediente1 == 1 && ingrediente2 == 2) ||
                (ingrediente1 == 2 && ingrediente2 == 1))
                    {
                        precioBase = 10000;
                        iva = 0.19;
                    }
                    // Res + Tocineta
                    else if ((ingrediente1 == 1 && ingrediente2 == 3) ||
                             (ingrediente1 == 3 && ingrediente2 == 1))
                    {
                        precioBase = 15000;
                        iva = 0.17;
                    }
                    // Chorizo + Tocineta
                    else if ((ingrediente1 == 4 && ingrediente2 == 3) ||
                             (ingrediente1 == 3 && ingrediente2 == 4))
                    {
                        precioBase = 25000;
                        iva = 0.09;
                    }
                    // Cualquier otra combinación
                    else
                    {
                        precioBase = 22000;
                        iva = 0.10;
                    }


                    Console.WriteLine();
                    Console.WriteLine("-------- RESULTADO --------");
                    Console.WriteLine("Tipo de pizza: No vegetariana");
                    Console.WriteLine("Ingredientes: " + ingrediente1 + ", "
                                      + ingrediente2);

                    Console.WriteLine("Precio base: $" + precioBase.ToString("N0"));
                    Console.WriteLine("IVA: " + iva + "%");
                    Console.WriteLine("Valor del IVA: $" + valorIVA.ToString("N0"));
                    Console.WriteLine("Precio final: $" + precioFinal.ToString("N0"));
                }
            }

            Console.ReadKey();
        }
                
            }
        }
    }
}
