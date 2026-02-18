namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.PagSeguro;

internal class PagSeguroProcessor : AbstractProducts.IProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}