using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CondicionalsimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  //Estructura de control condicional
              //1. Crea un algortimo que lea la edad de un usuario , si el usuario es mayor de 18 , se debe mostrar el siguiente mensajr "bienvenido a sitio web"
              byte edad = 0;
              Console.WriteLine("ingrese su edad");
              edad = Convert.ToByte(Console.ReadLine());//el convert es por que los datos vienen en string y esto es para cambiarlos a byte
              if(edad >=18)
              {
                  // si la condicion es verdadera
                  Console.WriteLine("Bienvenido a mi sitio web");
              }*/
            decimal sueldo = 0;
            string nombre = "";
            Console.WriteLine("ingrese su sueldo mensual");
            sueldo=Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            if (sueldo>=3000)
            {
                Console.WriteLine("debes abonar impuestos");
            }
            byte edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());//el convert es por que los datos vienen en string y esto es para cambiarlos a byte
            if (edad >= 18)
            {
                // si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");

            
            }
            else
            {
                Console.WriteLine("No eres apto para este sitio web");
            }
            




        }
    }
}
