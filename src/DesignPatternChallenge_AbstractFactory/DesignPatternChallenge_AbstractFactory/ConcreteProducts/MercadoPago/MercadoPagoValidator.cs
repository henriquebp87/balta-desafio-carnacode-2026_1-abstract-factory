namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.MercadoPago
{
    internal class MercadoPagoValidator : AbstractProducts.IValidator
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("MercadoPago: Validando cartão...");
            return cardNumber.Length == 16 && cardNumber.StartsWith("5");
        }
    }
}
