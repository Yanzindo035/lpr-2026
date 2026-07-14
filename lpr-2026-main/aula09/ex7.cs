using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>();

        Console.Write("Quantas cidades? ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome da cidade: ");
            string nome = Console.ReadLine();

            Console.Write("População: ");
            int pop = int.Parse(Console.ReadLine());

            cidades[nome] = pop;
        }

        int soma = 0;
        foreach (var c in cidades)
            soma += c.Value;

        double media = (double)soma / cidades.Count;

        Console.WriteLine("\nCidades acima da média:");
        foreach (var c in cidades)
        {
            if (c.Value > media)
                Console.WriteLine(c.Key);
        }

        string maior = "";
        string menor = "";
        int maiorPop = 0;
        int menorPop = int.MaxValue;

        foreach (var c in cidades)
        {
            if (c.Value > maiorPop)
            {
                maiorPop = c.Value;
                maior = c.Key;
            }

            if (c.Value < menorPop)
            {
                menorPop = c.Value;
                menor = c.Key;
            }
        }

        Console.WriteLine("\nCidade mais populosa: " + maior);
        Console.WriteLine("Cidade menos populosa: " + menor);

        Console.Write("\nDigite a população para remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var c in cidades)
        {
            if (c.Value == y)
                remover.Add(c.Key);
        }

        foreach (string cidade in remover)
            cidades.Remove(cidade);

        Console.WriteLine("\nDicionário atualizado:");
        foreach (var c in cidades)
            Console.WriteLine(c.Key + " - " + c.Value);
    }
}