using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] notas = new double[10];

        int aprovados = 0;
        int recuperacao = 0;
        int reprovados = 0;

        double soma = 0;

        // Cadastro dos alunos
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Aluno " + (i + 1));

            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Nota: ");
            notas[i] = double.Parse(Console.ReadLine());

            soma += notas[i];
        }

        Console.WriteLine("\nRELATÓRIO\n");

        // Relatório
        for (int i = 0; i < 10; i++)
        {
            string situacao;

            if (notas[i] >= 70)
            {
                situacao = "Aprovado";
                aprovados++;
            }
            else if (notas[i] >= 50)
            {
                situacao = "Recuperação";
                recuperacao++;
            }
            else
            {
                situacao = "Reprovado";
                reprovados++;
            }

            Console.WriteLine(nomes[i] + " - " +
                              notas[i] + " - " +
                              situacao);
        }

        double media = soma / 10;

        Console.WriteLine("\nAprovados: " + aprovados);
        Console.WriteLine("Recuperação: " + recuperacao);
        Console.WriteLine("Reprovados: " + reprovados);
        Console.WriteLine("Média da turma: " + media);
    }
}