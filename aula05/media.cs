using System;

class Program
{
    static void Main()
    {
        int quantidade, contador = 0;
        int numero;
        int soma = 0;
        int qtdPares = 0;

        Console.Write("Digite a quantidade de números: ");
        quantidade = int.Parse(Console.ReadLine());

        while (contador < quantidade)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                soma += numero;
                qtdPares++;
            }

            contador++;
        }

        if (qtdPares > 0)
        {
            double media = (double)soma / qtdPares;
            Console.WriteLine("Média dos números pares: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}