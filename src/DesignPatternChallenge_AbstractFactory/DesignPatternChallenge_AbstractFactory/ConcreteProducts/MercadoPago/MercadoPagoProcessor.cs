namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.MercadoPago
{
    internal class MercadoPagoProcessor : AbstractProducts.IProcessor
    {
        public string ProcessTransaction(decimal amount, string cardNumber)
        {
            Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
            return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
