using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public void AdicionarMatricula(Matricula matricula)
    {
        if (Matriculas.Any(m => m.Turma == matricula.Turma))
        {
            Console.WriteLine("Aluno já matriculado nessa turma.");
            return;
        }

        Matriculas.Add(matricula);
        matricula.Turma.AdicionarMatricula(matricula);
    }
}

class Turma
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Turma(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public void AdicionarMatricula(Matricula matricula)
    {
        if (!Matriculas.Contains(matricula))
        {
            Matriculas.Add(matricula);
        }
    }

    public List<Aluno> ListarAlunos()
    {
        return Matriculas.Select(m => m.Aluno).ToList();
    }
}

class Matricula
{
    public Aluno Aluno { get; set; }
    public Turma Turma { get; set; }
    public DateTime DataMatricula { get; set; }

    public Matricula(Aluno aluno, Turma turma)
    {
        Aluno = aluno;
        Turma = turma;
        DataMatricula = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno("Yan");
        Aluno a2 = new Aluno("Pedro");

        Turma t1 = new Turma("Informática");
        Turma t2 = new Turma("Eletrônica");

        a1.AdicionarMatricula(new Matricula(a1, t1));
        a1.AdicionarMatricula(new Matricula(a1, t2));
        a2.AdicionarMatricula(new Matricula(a2, t1));

        // Teste de matrícula duplicada
        a1.AdicionarMatricula(new Matricula(a1, t1));

        Console.WriteLine("\nAlunos da turma " + t1.Nome + ":");

        foreach (Aluno aluno in t1.ListarAlunos())
        {
            Console.WriteLine(aluno.Nome);
        }
    }
}