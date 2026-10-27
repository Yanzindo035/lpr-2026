using System;

class Aluno
{
    public int matricula;
    public string nome;
    public double nota1;
    public double nota2;
    public double notaTrabalho;

    public double media()
    {
        return (nota1 * 2.5 + nota2 * 2.5 +
                notaTrabalho * 2) / 7;
    }

    public double final()
    {
        if (media() < 60)
            return 120 - media();

        return 0;
    }
}

class Program
{
    static void Main()
    {
        Aluno a = new Aluno();

        Console.Write("Matrícula: ");
        a.matricula = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        a.nome = Console.ReadLine();

        Console.Write("Nota da prova 1: ");
        a.nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota da prova 2: ");
        a.nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota do trabalho: ");
        a.notaTrabalho = double.Parse(Console.ReadLine());

        Console.WriteLine("Média: " + a.media());

        if (a.final() > 0)
            Console.WriteLine("Precisa tirar " + a.final() + " na final.");
        else
            Console.WriteLine("Aprovado, não precisa de final.");
    }
}