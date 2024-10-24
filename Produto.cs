public abstract class Produto 
{
   public string Nome { get; set; } // encapsulamento
   public string Codigo { get; set; } // encapsulamento
   public decimal Preco { get; set; } // encapsulamento

   public abstract decimal CalcularPrecoFinal(); // Polimorfismo e abstração 
}