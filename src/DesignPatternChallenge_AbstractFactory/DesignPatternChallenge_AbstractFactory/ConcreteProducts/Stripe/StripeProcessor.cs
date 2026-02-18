namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.Stripe;

internal class StripeProcessor : AbstractProducts.IProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando ${amount}...");
        return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}