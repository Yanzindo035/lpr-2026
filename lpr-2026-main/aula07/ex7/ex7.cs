using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        // Leitura da matriz A
        Console.WriteLine("Matriz A");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite um valor: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Leitura da matriz B
        Console.WriteLine("\nMatriz B");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite um valor: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Multiplicação das matrizes
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = 0;

                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Exibir resultado
        Console.WriteLine("\nResultado A * B:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(C[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}