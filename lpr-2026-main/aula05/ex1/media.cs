using System;

class Program
{
    static void Main()
    {
        int quantidade;
        int i = 0;
        int numero;
        int soma = 0;
        int contador = 0;
        Console.Write("Quantos números você vai digitar? ");
        quantidade = int.Parse(Console.ReadLine());
        while (i < quantidade)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                soma = soma + numero;
                contador = contador + 1;
            }
            i = i + 1;
        }
        if (contador > 0)
        {
            double media = (double)soma / contador;
            Console.WriteLine("Média dos pares: " + media);
        }
        else
        {
            Console.WriteLine("Você não digitou números pares.");
        }
    }
}