using System;

public class Jogador
{
    public string nome;
    public int vida;
    public int nivel;

    public void atacar()
    {
        Console.WriteLine(nome + " está atacando!");
    }

    public void pular()
    {
        Console.WriteLine(nome + " pulou!");
    }

    public void usarEspada()
    {
        Console.WriteLine(nome + " está usando uma espada!");
    }
}