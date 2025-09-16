using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4___yordan
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un monto en soles: ");
            double soles = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSeleccione una opcion: ");
            Console.WriteLine("1. Dolares");
            Console.WriteLine("2. Euros");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1: Console.WriteLine($"\nUSD: { + (soles / 3.75):F0}"); break;
                case 2: Console.WriteLine($"\nEUR: { + (soles / 4.05):F2}"); break;
                default: Console.WriteLine("Opcion incorrecta"); break;
            }
        }
    }
}
