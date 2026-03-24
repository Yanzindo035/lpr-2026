using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" MENU DE CLASSES RPG ");
        Console.WriteLine("1 Guerreiro");
        Console.WriteLine("2 Mago");
        Console.WriteLine("3 Arqueiro");
        Console.Write("Escolha sua classe (1-3): ");

        string escolha = Console.ReadLine();

        Console.WriteLine("\n HABILIDADES ");

        switch (escolha)
        {
            case "1":
                Console.WriteLine("Classe: Guerreiro");
                Console.WriteLine("Habilidades: Golpe Pesado, Escudo Espelhado e Fúria de Batalha.");
                break;
            case "2":
                Console.WriteLine("Classe: Mago");
                Console.WriteLine("Habilidades: Bola de Fogo, Nevasca e Teletransporte.");
                break;
            case "3":
                Console.WriteLine("Classe: Arqueiro");
                Console.WriteLine("Habilidades: Chuva de Flechas, Tiro Preciso e Camuflagem.");
                break;

            default:
                Console.WriteLine("Opção inválida, escolha uma classe entre 1 e 3.");
                break;  

    }
}