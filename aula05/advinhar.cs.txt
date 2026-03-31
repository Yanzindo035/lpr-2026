using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101);

        int chute;
        int tentativas = 0;

        Console.WriteLine("Adivinhe o número entre 1 e 100");

        do
        {
            Console.Write("Digite um numero: ");
            chute = int.Parse(Console.ReadLine());
            tentativas++;

            if (chute > valorInteiro)
            {
                Console.WriteLine("Numero e menor");
            }
            else if (chute < valorInteiro)
            {
                Console.WriteLine("Numero e maior");
            }
            else
            {
                Console.WriteLine("Acertou!");
            }

        } while (chute != valorInteiro);

        Console.WriteLine("Você acertou em " + tentativas + " tentativas.");
    }
}