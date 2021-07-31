using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_centigrados_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de grados centigrados: ");
            int centigrados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fahrenheit = {0}", centigrados * 9 / 5 + 32);

            Console.ReadLine();


        }
    }
}
