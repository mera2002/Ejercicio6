using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VICTOR RICARDO ALVAREZ SARAVIA 
//MERARY JULISSA ARAUJO VELASQUEZ 

namespace Programa_saludo_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string saludo;
            string Nombre = ", Merary";

            Console.WriteLine("Ingrese un saludo:");
            saludo = Console.ReadLine();

            Console.WriteLine(saludo + Nombre);
            Console.ReadKey();
        }
    }
}
