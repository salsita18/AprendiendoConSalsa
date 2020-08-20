using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoConSalsa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hola Mundo!

            Console.WriteLine("Los saluda, salsita de Salsa Tecnologica");

            Console.WriteLine("¿Como te llamas?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Che, un gusto viejardo, que buen nombre: ");
            Console.WriteLine(nombre);

            Console.WriteLine("¿Y cual es tu edad?");
            string edad = Console.ReadLine();

            Console.WriteLine("Que copado tener: ");
            Console.WriteLine(edad);

            Console.ReadLine();
        }
    }
}
