using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM7_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, pa = 0, im = 0;
            do 
            {
                Console.Write("Ingrese número entero (negativo para finalizar): ");
                num = int.Parse(Console.ReadLine());

                if (num < 0) continue;
                if(num % 2 == 0) pa++;
                else im++;
            }while (num > 0);
            Console.WriteLine("\nHay " + pa + " números pares");
            Console.WriteLine("\nHay " + im + " números impares");
        }
    }
}
