using System;

class Program
{
    static int[,] sala = new int[6, 8];

    static string VerificarAssento(int linha, int coluna)
    {
        if (sala[linha, coluna] == 0)
            return "Livre";
        else
            return "Ocupado";
    }

    static void ReservarAssento()
    {
        int linha, coluna;

        Console.Write("Linha: ");
        linha = int.Parse(Console.ReadLine());

        Console.Write("Coluna: ");
        coluna = int.Parse(Console.ReadLine());

        if (sala[linha, coluna] == 0)
        {
            sala[linha, coluna] = 1;
            Console.WriteLine("Reserva realizada.");
        }
        else
        {
            Console.WriteLine("Assento ocupado.");
        }
    }

    static void CancelarReserva()
    {
        int linha, coluna;

        Console.Write("Linha: ");
        linha = int.Parse(Console.ReadLine());

        Console.Write("Coluna: ");
        coluna = int.Parse(Console.ReadLine());

        if (sala[linha, coluna] == 1)
        {
            sala[linha, coluna] = 0;
            Console.WriteLine("Reserva cancelada.");
        }
        else
        {
            Console.WriteLine("Assento já está livre.");
        }
    }

    static void ConsultarAssento()
    {
        int linha, coluna;

        Console.Write("Linha: ");
        linha = int.Parse(Console.ReadLine());

        Console.Write("Coluna: ");
        coluna = int.Parse(Console.ReadLine());

        Console.WriteLine("Status: " +
                          VerificarAssento(linha, coluna));
    }

    static void MostrarMapa()
    {
        Console.WriteLine("\nMAPA DA SALA");

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(sala[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("\n1 - Reservar assento");
            Console.WriteLine("2 - Cancelar reserva");
            Console.WriteLine("3 - Consultar assento");
            Console.WriteLine("4 - Mostrar mapa da sala");
            Console.WriteLine("5 - Encerrar");

            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ReservarAssento();
                    break;

                case 2:
                    CancelarReserva();
                    break;

                case 3:
                    ConsultarAssento();
                    break;

                case 4:
                    MostrarMapa();
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (op != 5);
    }
}