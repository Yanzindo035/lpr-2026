using System;

class Retangulo
{
    public double Altura;
    public double Largura;

    public double calcArea()
    {
        return Altura * Largura;
    }

    public double calcPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo();

        Console.Write("Digite a altura: ");
        r.Altura = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura: ");
        r.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Área: " + r.calcArea());
        Console.WriteLine("Perímetro: " + r.calcPerimetro());
    }
}