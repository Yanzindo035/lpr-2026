using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> notas = new List<double>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite uma nota: ");
            notas.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nNotas: ");
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }

        Console.WriteLine("Maior nota: " + notas.Max());
        Console.WriteLine("Menor nota: " + notas.Min());
        Console.WriteLine("Média: " + notas.Average());
    }
}