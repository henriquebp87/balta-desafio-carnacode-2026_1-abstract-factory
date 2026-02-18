namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.Stripe;

internal class StripeValidator : AbstractProducts.IValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }
}