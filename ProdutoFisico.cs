using System.Dynamic;

public class Dimensoes
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }
}

public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public Dimensoes Dimensao { get; set; }
    public string Categoria { get; set; }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaImposto = 0.10m;
        decimal valorPorKg = 5.0m;
        decimal custoEnvio = (decimal)Peso* valorPorKg;
        decimal imposto = Preco * taxaImposto;

        return Preco + imposto + custoEnvio;
    }
}