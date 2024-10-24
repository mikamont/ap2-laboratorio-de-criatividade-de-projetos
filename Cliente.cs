public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public void ExibirInfromacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"ID: {NumeroIdentificacao}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Contato: {Contato}");
    }

}