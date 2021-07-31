using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepractica29_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "merary"; //operador de asignacion 
            string saludo = "Bienvenidos";

            //operadores
            // Console.WriteLine(8 + 7); //suma valores 
            //Console.WriteLine(saludo + nombre); //concatenar 

            //decxlaracion 
            int a = 10, b = 20; //declaracion y asignatura 

            if(a < b) //operador de comparacion 
            {
                Console.WriteLine("a es menor a b");

            }
            else if (a > b)

            {
                Console.WriteLine("a es mayor a b");

            }


            {
                Console.WriteLine("a es igual a b");
            }

            Console.ReadKey();

        }
    }
}
