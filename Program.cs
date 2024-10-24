class Program
{
    static void Main()
    {
        Loja loja = new Loja();

        // Cadastrar produtos
        ProdutoFisico produtoFisico = new ProdutoFisico { Nome = "Celular", Codigo = "P001", Preco = 3000, Peso = 2.5, Dimensao = new Dimensoes { Altura = 30, Largura = 20, Profundidade = 5 }, Categoria = "Eletrônicos" };
        ProdutoDigital produtoDigital = new ProdutoDigital { Nome = "Livro", Codigo = "P002", Preco = 50, TamanhoArquivo = 1.5, Formato = "PDF" };

        loja.CadastrarProduto(produtoFisico);
        loja.CadastrarProduto(produtoDigital);

        // Cadastrar cliente
        Cliente cliente = new Cliente { Nome = "Mikael Monteiro", NumeroIdentificacao = "120321", Endereco = "Estrada Geral Do jacaré 805", Contato = "mikael@gmail" };
        loja.CadastrarCliente(cliente);

        // Criar pedido
        Pedido pedido = loja.CriarPedido(cliente);
        pedido.AdicionarProduto(produtoFisico);
        pedido.AdicionarProduto(produtoDigital);

        // Calcular total
        Console.WriteLine($"Total do pedido: {pedido.CalcularTotal()}");

        // Finalizar pedido
        loja.FinalizarPedido(pedido);
        loja.ListarPedidos();
    }
}
