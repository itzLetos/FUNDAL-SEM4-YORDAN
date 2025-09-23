using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SEMANA5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pares = 0, impares = 0, ceros = 0;
            Console.Write("ingrse la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cant; i++) 
            { 
                Console.Write($"\nIngrese numero {i}: ");
                int num = int.Parse(Console.ReadLine()); 
                
                if(num == 0 ) ceros++;
                else if (num % 2 == 0) pares++;
                else impares++;
            }
            Console.WriteLine("\n# Ceros: " + ceros);
            Console.WriteLine("\n# Pares: " + pares);
            Console.WriteLine("\n# Impares: " + impares);
        }
    }
}
