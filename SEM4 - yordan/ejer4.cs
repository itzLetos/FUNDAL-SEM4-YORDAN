using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SEM4___yordan
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenidos al calculo de áreas\n");
            Console.WriteLine("1. cuadrado");
            Console.WriteLine("2. rectangulo");
            Console.WriteLine("3. triangulo");
            Console.WriteLine("4. circulo");
            Console.Write("\ningrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1: Console.Write("\ningrese un lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.Write("\nArea: " + (lado * lado)); break;
                case 2:
                    Console.Write("\ningrese la base: ");
                    int bas = int.Parse(Console.ReadLine());
                    Console.Write("\ningrese la altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.Write("\nArea: " + (bas * alt)); break;
                case 3:
                    Console.Write("\ningrese la base: ");
                    int bas2 = int.Parse(Console.ReadLine());
                    Console.Write("\ningrese la altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.Write("\nArea: " + ((bas2 * alt2) / 2)); break;
                case 4:
                    Console.Write("\ningrese el radio: ");
                    double rad = double.Parse(Console.ReadLine());
                    Console.Write("\nArea: " + Math.Round(Math.PI * (rad*rad),2)); break;
                default: Console.WriteLine("\nOpcion incorrecta"); break;
            }
        }
    }
}
