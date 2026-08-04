using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numericos
            //Incremento / decremento
            int dato1 = 0;
            dato1++;//Dato1=dato1+1; Incremento
            dato1--;//dato1=dato1-1; Decremento
            dato1 += 5;//dato1+5 incrementa 5 unidades
            dato1 *= 3;//dato 1 se multiplica por 3
            dato1 /= 2;//dato1 se divide entre 2
            dato1 += dato1;//se le suma el mismo dato 1

            //orden de evaluacion de operadores numericos
            float dato2 = 4 / 3 * 2; //se ejecuta normal ya que tiene el mismo nivel de importancia
            float dato3 = 4 * (2 / 3);// se ejecuta primero el parentesis
            float dato4 = 4 + 6 * 2; // se ejecuta primero la multiplicacion
            float dato5 = 4 + 6 * (2 - 1);
            float dato6 = dato2 * dato3 - dato4 / dato5;

            //Operadores logicos
            //conjuncion -AND-Y-&&
            Console.WriteLine("-------------TABLA DE LA CONJUNCIÓN-------------");
            Console.WriteLine("V && V= " + (true && true));
            Console.WriteLine("V && F= " + (true && false));
            Console.WriteLine("F && V= " + (false && true));
            Console.WriteLine("F && F= " + (false && false));
            Console.WriteLine("--------------------------");

            //Disyunción- OR -0-||
            Console.WriteLine("-------------TABLA DE LA DISYUNCIÓN-------------");
            Console.WriteLine("V && V= " + (true || true));
            Console.WriteLine("V && F= " + (true || false));
            Console.WriteLine("F && V= " + (false|| true));
            Console.WriteLine("F && F= " + (false || false));
            Console.WriteLine("--------------------------";


            bool dato7 = true;
            bool dato8 = !dato7;
            //Operadores de comparación
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 25 == 25;
            bool dato12 = 4 != 4;
            bool dato13 = 5 < 4 && dato7;
            bool dato14 = 0 == 1 || 12 > 3 && dato9;  

        }
    }
}
