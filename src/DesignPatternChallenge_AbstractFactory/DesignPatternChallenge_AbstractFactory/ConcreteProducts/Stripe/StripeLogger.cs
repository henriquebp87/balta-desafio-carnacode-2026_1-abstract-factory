namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.Stripe
{
    internal class StripeLogger : AbstractProducts.ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
        }
    }
}
