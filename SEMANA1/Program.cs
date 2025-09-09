using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
            Console.ReadKey(); //detenimiento de consola
        }

        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso " +
                $"de Fundamentos de Algoritmo de la carrera {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Leonardo\"");
        }

        static void ejer3()
        {
            Console.Write("ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double div = (double)num1 / (double)num2;

            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Division: " + div);
        }

        static void ejer4()
        {
            Console.WriteLine("ingrese un numero decimal");
            double num = double.Parse(Console.ReadLine());

            double ra = Math.Sqrt(num); //para raiz cuadrada
            double redo = Math.Round(num,2); //para redondear cantidad de decimales, el 2 lo indica
            double cubo = Math.Pow(num,3); //para potencias, el 3 indica la potencia
            double cubica = Math.Pow(num,1/3d); //raiz cubica representada en exponente fracción, la d en la fraccion indica que es decimal

            Console.WriteLine("\nRaiz cuadrada: " + ra);
            Console.WriteLine("\nRedondeado: " + redo);
            Console.WriteLine("\nElevado a 3: " + cubo);
            Console.WriteLine("\nRaiz cubica: " + cubica);
        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
