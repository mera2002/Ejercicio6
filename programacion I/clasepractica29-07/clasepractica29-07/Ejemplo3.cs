using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepractica29_07
{
    class Ejemplo3
    {

        //ENUM
        //es una clase especial
        public enum Dias{
            LUNES, MARTES, MIERCOLES, JUEVES, VIERNES
        }


        static void Main(string[] args)
        {


            Console.WriteLine("escriba en  numero correspondiente al dia de la semana:");
            int dia = Int32.Parse(Console.ReadLine()); //conversion de tipo de dato 

            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.LUNES);
                    break;
                case 2:
                    Console.WriteLine(Dias.MARTES);
                    break;
            }
            Console.ReadKey();
}
}
}
