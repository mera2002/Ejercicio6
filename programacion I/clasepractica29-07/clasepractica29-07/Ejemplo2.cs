using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepractica29_07
{
    class Ejemplo2
    {
        static void Main(string[] args)
        {

            // intruccion swith 

            int a = 10;

            switch(a)
            {
                case 5:
                    Console.WriteLine("el valor de a es 5");
                    break;
                case 10:
                    Console.WriteLine("el valor de a es 10");
                    break;
                default:
                    Console.WriteLine("el valor no es conocido");
                    break;
                    

            }
        }
    }

}
