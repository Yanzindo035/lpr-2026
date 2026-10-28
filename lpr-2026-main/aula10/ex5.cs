using System;

class Produto
{
    public string nome;
    public double preco;
}

class Pedido
{
    public Produto produto;
    public int quantidade;
}

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        p.nome = "Mouse";
        p.preco = 50.00;

        Pedido pedido = new Pedido();
        pedido.produto = p;
        pedido.quantidade = 3;

        double total = pedido.produto.preco * pedido.quantidade;

        Console.WriteLine("Produto: " + pedido.produto.nome);
        Console.WriteLine("Quantidade: " + pedido.quantidade);
        Console.WriteLine("Preço total: R$ " + total);
    }
}