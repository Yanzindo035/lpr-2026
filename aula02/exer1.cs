using System;
using System.Globalization;

namespace ExercicioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

          
            double raio = double.Parse(Console.ReadLine(), CI);

            double pi = 3.14159;

          
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CI));
        }
    }
}