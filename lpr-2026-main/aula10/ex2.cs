using System;

class Funcionario
{
    public string nome;
    public double salarioBruto;
    public double imposto;

    public double salarioLiquido()
    {
        if (salarioBruto <= 2000)
            imposto = salarioBruto * 0.10;
        else if (salarioBruto <= 3000)
            imposto = salarioBruto * 0.15;
        else
            imposto = salarioBruto * 0.20;

        return salarioBruto - imposto;
    }

    public void mostrarDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário líquido: " + salarioLiquido());
    }

    public void aumentarSalario(double porcentagem)
    {
        salarioBruto += salarioBruto * porcentagem / 100;
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario();

        Console.Write("Nome: ");
        f.nome = Console.ReadLine();

        Console.Write("Salário bruto: ");
        f.salarioBruto = double.Parse(Console.ReadLine());

        f.mostrarDados();

        Console.Write("Porcentagem de aumento: ");
        double porcentagem = double.Parse(Console.ReadLine());

        f.aumentarSalario(porcentagem);

        Console.WriteLine("\nDados após o aumento:");
        f.mostrarDados();
    }
}