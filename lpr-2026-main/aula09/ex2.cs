using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Quantos nomes deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine());

        List<List<string>> linhas = new List<List<string>>();

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            bool colocado = false;

            
            foreach (List<string> linha in linhas)
            {
                bool tamanhoExiste = false;

                foreach (string n in linha)
                {
                    if (n.Length == nome.Length)
                    {
                        tamanhoExiste = true;
                        break;
                    }
                }

                if (!tamanhoExiste)
                {
                    linha.Add(nome);
                    colocado = true;
                    break;
                }
            }

            
            if (!colocado)
            {
                linhas.Add(new List<string>());
                linhas[linhas.Count - 1].Add(nome);
            }
        }

        
        Console.WriteLine("\nSaída:");
        foreach (List<string> linha in linhas)
        {
            linha.Sort((a, b) => a.Length.CompareTo(b.Length));

            foreach (string nome in linha)
            {
                Console.Write(nome + " ");
            }

            Console.WriteLine();
        }
    }
}