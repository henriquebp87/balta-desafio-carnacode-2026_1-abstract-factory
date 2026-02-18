namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.MercadoPago
{
    internal class MercadoPagoLogger : AbstractProducts.ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
        }
    }
}
