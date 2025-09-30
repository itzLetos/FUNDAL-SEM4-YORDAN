using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM7_C_
{
    internal class ejer2
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("*  BIENVENIDOS AL JUEGO ADIVINA UN NÚMERO  *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("* Instrucciones:                           *");
            Console.WriteLine("* 1. Tienes 3 intentos                     *");
            Console.WriteLine("* 2. Cada fallo ud. tendrá una pista       *");
            Console.WriteLine("********************************************");

            int intentos = 3;
            Random rnd = new Random();
            int secreto = rnd.Next(1, 21);
            int num;

            do 
            {
                Console.WriteLine("\nIngrese el número a adivinar: ");
                num = int.Parse(Console.ReadLine());

                if (secreto == num)
                {
                    Console.WriteLine("\nCorrecto! adivinaste el número!");
                    return;
                }
                else 
                {
                    intentos--;
                    if (num < secreto)
                    {
                        Console.WriteLine("\nEl número es mayor");
                    }
                    else 
                    {
                        Console.WriteLine("\nEl número es menor");
                    }
                }
            }while (intentos > 0);

            Console.WriteLine($"\nNo lograste adivinar el número {secreto}!");
        }
    }
}
