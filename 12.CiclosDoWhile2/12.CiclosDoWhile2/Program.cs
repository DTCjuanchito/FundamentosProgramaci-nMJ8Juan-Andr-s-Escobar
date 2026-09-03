using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CiclosDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string Nombres;
            int cuenta;
            int saldo;
            int Usuarios = 0;
            int SumaSaldos = 0;


         


            do
            {
              
                Console.WriteLine("Ingrese su nombre completo");
                Nombres = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de cuenta");
                cuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = int.Parse(Console.ReadLine());
                Usuarios++;
                SumaSaldos += saldo;
                if (saldo > 3000000)
                {
                    Console.WriteLine($"su nombre es:{Nombres}");
                    Console.WriteLine($"su número de cuenta es :{cuenta}");
                    Console.WriteLine($"su saldo es :{saldo}");
                    Console.WriteLine("Es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"su nombre es:{Nombres}");
                    Console.WriteLine($"su número de cuenta es :{cuenta}");
                    Console.WriteLine($"su saldo es :{saldo}");
                    Console.WriteLine("NO ES APTO para el credito");
                }


                Console.WriteLine("desea seguir operando a mas usuarios");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
           

            Console.WriteLine($"La cantidad de usuarios es:{Usuarios}");
            float promedio=SumaSaldos/Usuarios;

            Console.WriteLine($"El promedio de los saldos son:{promedio}");







        }
    }
}
