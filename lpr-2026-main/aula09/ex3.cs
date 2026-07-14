using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

       
        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(1, 101)); 
        }

        
        numeros.Sort();

        Console.WriteLine("Lista ordenada:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

      
        numeros.RemoveAll(n => n % 2 == 0);

        Console.WriteLine("\n\nLista sem os números pares:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

       
        Console.WriteLine("\n\nNúmeros repetidos:");
        bool repetiu = false;

        for (int i = 0; i < numeros.Count; i++)
        {
            int contador = 0;

            for (int j = 0; j < numeros.Count; j++)
            {
                if (numeros[i] == numeros[j])
                    contador++;
            }

            if (contador > 1)
            {
                bool jaMostrou = false;

                for (int k = 0; k < i; k++)
                {
                    if (numeros[k] == numeros[i])
                    {
                        jaMostrou = true;
                        break;
                    }
                }

                if (!jaMostrou)
                {
                    Console.WriteLine(numeros[i]);
                    repetiu = true;
                }
            }
        }

        if (!repetiu)
        {
            Console.WriteLine("Não existem números repetidos.");
        }
    }
}