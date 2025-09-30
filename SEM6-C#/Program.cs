using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SEM6_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al sistema de validacion de contraseñas\n");

            Console.Write("Genere una contraseña: ");
            string g = Console.ReadLine();

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("-      valide su contraseña      -");
            Console.WriteLine("--------------------------------\n");

            int intentos = 3;

            while (intentos > 0) 
            {
                Console.Write("\nIngrese la contraseña: ");
                string i = Console.ReadLine();

                if (i == g)
                {
                    Console.Write("\nAcceso concedido. Bienvenido al sistema");
                    return;
                }
                else 
                {
                    intentos --;
                    Console.Write("\nContraseña incorrecta. Intentos restantes: "+intentos);
                }
            }
            Console.WriteLine("\nAcceso denegado. Cerrando programa!");
        }
    }
}
