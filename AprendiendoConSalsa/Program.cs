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
            
            // si soy mayor de edad, entonces: paso al boliche, sino: no paso al boliche

            
            Console.WriteLine("Que quieres hacer?");
            string intencion = Console.ReadLine();
            
            Console.WriteLine("Cual es tu edad?");
            string textoEdad = Console.ReadLine();

            // 3 != "3"

            int numeroEdad = int.Parse(textoEdad);

            if (intencion == "ir al boliche")
            {
                if (numeroEdad >= 18)
                {
                    Console.WriteLine("Puedes pasar.");
                }
                else
                {
                    Console.WriteLine("No puedes pasar.");
                }
            }
            else
            {
                if (numeroEdad >= 21)
                {
                    Console.WriteLine("Puedes casarte.");
                }
                else
                {
                    Console.WriteLine("No puedes casarte.");
                }
            }
            


            Console.ReadLine();
        }
    }
}
