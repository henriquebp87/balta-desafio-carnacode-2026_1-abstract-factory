namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.PagSeguro;

internal class PagSeguroValidator : AbstractProducts.IValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}