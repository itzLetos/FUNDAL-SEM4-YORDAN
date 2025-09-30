using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM7_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            string opc;
            int sum = 0;
            do 
            {
                Console.Clear();
                Console.Write("Ingrese un número positivo: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i < num; i++)
                    sum += i;

                Console.WriteLine("\nSuma: " +  sum);

                Console.WriteLine("\n¿Desea continuar (S/N)?: ");
                opc = Console.ReadLine();

                if (opc == "S") continue;
                else Console.WriteLine("\nIncorrecto"); return;
            }while (opc != "N");
            Console.WriteLine("\nPrograma finalizado!");
        }
    }
}
