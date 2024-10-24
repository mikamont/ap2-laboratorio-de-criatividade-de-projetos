using System.Net.Http.Headers;

public class Loja
{
    private List<Produto> produtos = new List<Produto>();
    private List<Cliente> clientes = new List<Cliente>();
    private List<Pedido> pedidos = new List<Pedido>();

    public void CadastrarProduto(Produto produto)
    {
        if (produto != null && !produtos.Contains(produto))
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} cadastrado.");
        }
    }
public Produto ConsultarProdutoPorCodigo(string codigo)
{
    return produtos.Find(p => p.Codigo == codigo);
}

public void ListarProdutos()
{
    foreach (var produto in produtos)
    {
        Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
    }
}

 public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null && !clientes.Contains(cliente))
        {
            clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Nome} cadastrado.");
        }
    }

public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        return clientes.Find(c => c.NumeroIdentificacao == numeroIdentificacao);
    }

    public void ListarClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Cliente: {cliente.Nome}, ID: {cliente.NumeroIdentificacao}");
        }
    }

    public Pedido CriarPedido(Cliente cliente)
    {
        if (cliente != null && clientes.Contains(cliente))
        {
            Pedido pedido = new Pedido(cliente);
            pedidos.Add(pedido);
            return pedido;
        }
        return null;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        pedido.FinalizarPedido();
    }

    public void ListarPedidos()
    {
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"Pedido para {pedido.Cliente.Nome}, Status: {pedido.Status}");
        }
    }
}

