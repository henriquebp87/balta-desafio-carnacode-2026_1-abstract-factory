namespace DesignPatternChallenge_AbstractFactory.ConcreteProducts.PagSeguro
{
    internal class PagSeguroLogger : AbstractProducts.ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
        }
    }
}
