using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;

        // Leitura da matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite um número: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                soma += matriz[i, j];
            }
        }

        // Exibir matriz
        Console.WriteLine("\nMatriz:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }

        // Exibir soma
        Console.WriteLine("\nSoma = " + soma);
    }
}