using System;
using System.Collections.Generic;

struct Piloto
{
    public string Nome;
    public string Equipe;
    public int Pontos;
}

class Program
{
    static void Main()
    {
        List<Piloto> pilotos = new List<Piloto>();

        
        for (int i = 0; i < 10; i++)
        {
            Piloto p;

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Equipe: ");
            p.Equipe = Console.ReadLine();

            Console.Write("Pontos: ");
            p.Pontos = int.Parse(Console.ReadLine());

            pilotos.Add(p);
        }

        
        for (int i = 0; i < pilotos.Count - 1; i++)
        {
            for (int j = i + 1; j < pilotos.Count; j++)
            {
                if (pilotos[j].Pontos > pilotos[i].Pontos)
                {
                    Piloto aux = pilotos[i];
                    pilotos[i] = pilotos[j];
                    pilotos[j] = aux;
                }
            }
        }

        Console.WriteLine("\nRANKING");
        foreach (Piloto p in pilotos)
        {
            Console.WriteLine(p.Nome + " - " + p.Equipe + " - " + p.Pontos);
        }

        
        int soma = 0;
        foreach (Piloto p in pilotos)
            soma += p.Pontos;

        double media = (double)soma / pilotos.Count;
        Console.WriteLine("\nMédia: " + media);

        
        int cont = 0;
        foreach (Piloto p in pilotos)
        {
            if (p.Pontos > media)
                cont++;
        }

        Console.WriteLine("Pilotos acima da média: " + cont);

        
        string melhorEquipe = "";
        int maior = 0;

        foreach (Piloto p1 in pilotos)
        {
            int total = 0;

            foreach (Piloto p2 in pilotos)
            {
                if (p1.Equipe == p2.Equipe)
                    total += p2.Pontos;
            }

            if (total > maior)
            {
                maior = total;
                melhorEquipe = p1.Equipe;
            }
        }

        Console.WriteLine("Melhor equipe: " + melhorEquipe);
        Console.WriteLine("Total de pontos: " + maior);
    }
}