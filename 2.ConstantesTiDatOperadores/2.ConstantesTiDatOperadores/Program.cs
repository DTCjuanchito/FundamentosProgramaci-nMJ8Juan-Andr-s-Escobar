using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConstantesTiDatOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string iva="19%";
            string nombre = "Juan";
            nombre = "Alejandro";
            //el iva como es una constante no se le puede cambiar el valor
            //tipos de datos
            byte dato1 = 1;
            int dato2 = -12365;
            long dato3 = 123565656;
            float dato4 = 5.3f;
            double dato5=12.36d;
            decimal dato6 = 125636.3265932667m;
            char dato7 = '¿';//un solo caracter
            string dato8 = "dato8-*/67";
            bool dato9 = true;//puede ser true o false
            object dato10 = new object();

            //OPERADORES
            //OPERADORES NUMERICOS 
            //CAMBIO DE SIGNO
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11:{0},dato12:{1}", dato11, dato12);//{0},{1} son indices para indicar cual es el indice 1 y 0 y para concatenar
            int dato13 = 3 + 5;
            Console.WriteLine("la suma es:{0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("la resta es:{0}",dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("la producto es:{0}",dato15);
            float dato16 =(float) 5 / 3;// se pone float en vez de int para que muestre el decimal completo y se pone (float) para que salga el decimal en pantalla
            Console.WriteLine("la divición es:{0}",dato16);
        }
    }
}
