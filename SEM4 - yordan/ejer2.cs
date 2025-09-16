using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4___yordan
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un año");
            int a=int.Parse(Console.ReadLine());

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            {
                Console.WriteLine("año bisiesto");
            }
            else 
            {
                Console.WriteLine("año no bisiesto");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("año par");
            }
            else 
            {
                Console.WriteLine("año impar");
            }
            Console.ReadKey();
        }
    }
}
