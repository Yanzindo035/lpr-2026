using System;
using System.Collections.Generic;

struct Livro
{
    public string titulo;
    public string autor;
    public int ano;
    public int quantidade;
}

class Program
{
    static Dictionary<int, Livro> livros = new Dictionary<int, Livro>();

    static void CadastrarLivro()
    {
        Livro l = new Livro();

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Título: ");
        l.titulo = Console.ReadLine();

        Console.Write("Autor: ");
        l.autor = Console.ReadLine();

        Console.Write("Ano: ");
        l.ano = int.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        l.quantidade = int.Parse(Console.ReadLine());

        livros[codigo] = l;
    }

    static void BuscarLivro()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];
            Console.WriteLine("Título: " + l.titulo);
            Console.WriteLine("Autor: " + l.autor);
            Console.WriteLine("Ano: " + l.ano);
            Console.WriteLine("Quantidade: " + l.quantidade);
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void EmprestarLivro()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];

            if (l.quantidade > 0)
            {
                l.quantidade--;
                livros[codigo] = l;
                Console.WriteLine("Empréstimo realizado.");
            }
            else
            {
                Console.WriteLine("Sem exemplares disponíveis.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void ExibirRelatorio()
    {
        Console.WriteLine("Total de livros: " + livros.Count);

        Livro antigo = new Livro();
        Livro maiorQtd = new Livro();
        bool primeiro = true;

        Dictionary<string, int> autores = new Dictionary<string, int>();

        foreach (var item in livros)
        {
            Livro l = item.Value;

            if (primeiro)
            {
                antigo = l;
                maiorQtd = l;
                primeiro = false;
            }

            if (l.ano < antigo.ano)
                antigo = l;

            if (l.quantidade > maiorQtd.quantidade)
                maiorQtd = l;

            if (autores.ContainsKey(l.autor))
                autores[l.autor]++;
            else
                autores[l.autor] = 1;
        }

        Console.WriteLine("Livro mais antigo: " + antigo.titulo);
        Console.WriteLine("Livro com maior quantidade: " + maiorQtd.titulo);

        Console.WriteLine("\nLivros por autor:");
        foreach (var a in autores)
        {
            Console.WriteLine(a.Key + ": " + a.Value);
        }
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nCadastro do livro " + (i + 1));
            CadastrarLivro();
        }

        BuscarLivro();
        EmprestarLivro();
        ExibirRelatorio();
    }
}