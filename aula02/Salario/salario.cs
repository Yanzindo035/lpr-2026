using System;
using System.Globalization; 

class Program
{
    static void Main()
    {

        Console.Write("Digite o número do funcionário: ");
        int NF = int.Parse(Console.ReadLine());


        Console.Write("Digite a quantidade de horas trabalhadas: ");
        int HT = int.Parse(Console.ReadLine());

        
        Console.Write("Digite o valor que recebe por hora: ");
        double VH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double salario = HT * VH;

        Console.WriteLine($"numero = {NF}");
        

        Console.WriteLine($"salario = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}