using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}

class Biblioteca
{
    public List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ListarLivros()
    {
        foreach (Livro livro in livros)
        {
            Console.WriteLine("Título: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Ano: " + livro.AnoPublicacao);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro l1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro l2 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943);

        biblioteca.AdicionarLivro(l1);
        biblioteca.AdicionarLivro(l2);

        biblioteca.ListarLivros();
    }
}