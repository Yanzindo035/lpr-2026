using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];

        // Leitura dos números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Número a pesquisar
        Console.Write("\nDigite o número que deseja pesquisar: ");
        int pesquisa = int.Parse(Console.ReadLine());

        int ocorrencias = 0;

        Console.WriteLine("\nPosições encontradas:");

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == pesquisa)
            {
                Console.WriteLine($"Posição {i}");
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.WriteLine($"\nTotal de ocorrências: {ocorrencias}");
        }
        else
        {
            Console.WriteLine("\nNúmero não encontrado no vetor.");
        }
    }
}