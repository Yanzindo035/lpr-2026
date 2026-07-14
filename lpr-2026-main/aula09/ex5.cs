using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> jogos = new Dictionary<string, string>();

        // Cadastro de 5 jogos
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Digite o nome do " + i + "º jogo: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o gênero de " + nome + ": ");
            string genero = Console.ReadLine();

            jogos[nome] = genero;
        }

        // Consulta de um jogo
        Console.Write("\nDigite o nome de um jogo para consultar: ");
        string consulta = Console.ReadLine();

        // Verifica se o jogo existe
        if (jogos.ContainsKey(consulta))
        {
            Console.WriteLine("O gênero de " + consulta + " é: " + jogos[consulta]);
        }
        else
        {
            Console.WriteLine("Jogo não cadastrado.");
        }

        Console.ReadKey();
    }
}