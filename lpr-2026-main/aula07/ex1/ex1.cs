using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

    
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

     
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
                pares.Add(numeros[i]);
            else
                impares.Add(numeros[i]);
        }

        Console.Write("PAR: ");
        foreach (int num in pares)
            Console.Write(num + " ");

        Console.WriteLine();

        Console.Write("ÍMPAR: ");
        foreach (int num in impares)
            Console.Write(num + " ");
    }
}