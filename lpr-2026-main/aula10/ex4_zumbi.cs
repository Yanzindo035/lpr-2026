using System;

public class Zumbi
{
    public int vida = 20;
    public int dano = 3;

    public void atacar()
    {
        Console.WriteLine("O zumbi está atacando!");
    }

    public void receberDano()
    {
        vida = vida - 10;
        Console.WriteLine("O zumbi recebeu dano!");
    }
}