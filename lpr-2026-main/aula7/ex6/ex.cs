using System;

class Program
{
    static void Main()
    {
        string[] cidades =
        {
            "Vitória",
            "Belo Horizonte",
            "Rio de Janeiro",
            "São Paulo"
        };

        int[,] distancia =
        {
            {0, 524, 521, 882},
            {524, 0, 434, 586},
            {521, 434, 0, 429},
            {882, 586, 429, 0}
        };

        int origem, destino;

        do
        {
            Console.WriteLine("\nCidades:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + " - " + cidades[i]);
            }

            Console.Write("\nEscolha a cidade de origem: ");
            origem = int.Parse(Console.ReadLine());

            Console.Write("Escolha a cidade de destino: ");
            destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Distância: " +
                              distancia[origem, destino] +
                              " km");

        } while (origem != destino);

        Console.WriteLine("Programa encerrado.");
    }
}