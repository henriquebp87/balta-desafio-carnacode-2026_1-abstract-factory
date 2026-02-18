using DesignPatternChallenge_AbstractFactory.AbstractProducts;

namespace DesignPatternChallenge_AbstractFactory.AbstractFactory
{
    internal interface IPaymentProviderFactory
    {
        IProcessor CreateProcessor();
        IValidator CreateValidator();
        ILogger CreateLogger();
    }
}
