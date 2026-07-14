using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        Console.Write("Quantas pessoas? ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade;
        }

        double media = pessoas.Values.Average();

        Console.WriteLine("\nAcima da média:");
        foreach (var p in pessoas)
            if (p.Value > media)
                Console.WriteLine(p.Key);

        Console.WriteLine("\nMais velho:");
        foreach (var p in pessoas)
            if (p.Value == pessoas.Values.Max())
                Console.WriteLine(p.Key);

        Console.WriteLine("\nMais novo:");
        foreach (var p in pessoas)
            if (p.Value == pessoas.Values.Min())
                Console.WriteLine(p.Key);

        Console.Write("\nIdade para remover: ");
        int y = int.Parse(Console.ReadLine());

        foreach (var nome in pessoas.Where(p => p.Value == y).Select(p => p.Key).ToList())
            pessoas.Remove(nome);

        Console.WriteLine("\nDicionário atualizado:");
        foreach (var p in pessoas)
            Console.WriteLine(p.Key + " - " + p.Value);
    }
}