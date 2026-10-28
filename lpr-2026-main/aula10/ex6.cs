using System;
using System.Collections.Generic;

class Cliente
{
    public string nome;
    public List<Reserva> reservas = new List<Reserva>();

    public Cliente(string nome)
    {
        this.nome = nome;
    }

    public void AdicionarReserva(Reserva reserva)
    {
        reservas.Add(reserva);
        reserva.cliente = this;
    }

    public void ListarReservas()
    {
        Console.WriteLine("Reservas de " + nome + ":");

        foreach (Reserva reserva in reservas)
        {
            Console.WriteLine("Reserva: " + reserva.descricao);
        }
    }
}

class Reserva
{
    public string descricao;
    public Cliente cliente;

    public Reserva(string descricao)
    {
        this.descricao = descricao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente("Yan");

        Reserva r1 = new Reserva("Reserva 1");
        Reserva r2 = new Reserva("Reserva 2");

        cliente.AdicionarReserva(r1);
        cliente.AdicionarReserva(r2);

        cliente.ListarReservas();
    }
}