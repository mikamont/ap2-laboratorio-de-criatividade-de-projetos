using System.Dynamic;

public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; private set; }
    public string Status { get; set; }

    private List<Produto> produtos = new List<Produto>();

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em processamento";
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto != null)
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido.");
        }
    }

    public void RemoverProduto(Produto produto)
    {
        if (produtos.Remove(produto))
        {
            Console.WriteLine($"Produto {produto.Nome} removido do pedido.");
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in produtos)
        {
            total += produto.CalcularPrecoFinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        Status = "Concluido";
        Console.WriteLine($"Pedido finalizado com sucesso.");
    }
}