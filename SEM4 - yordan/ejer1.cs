using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4___yordan
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 8) Console.WriteLine("menor de edad");
            else 
            {
                if (edad <= 64) Console.WriteLine("Adulto");
                else Console.WriteLine("Adulto mayor");
            }
            Console.ReadKey();
        }
    }
}
