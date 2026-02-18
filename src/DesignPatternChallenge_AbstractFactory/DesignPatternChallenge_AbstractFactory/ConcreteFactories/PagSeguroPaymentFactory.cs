using DesignPatternChallenge_AbstractFactory.AbstractFactory;
using DesignPatternChallenge_AbstractFactory.AbstractProducts;
using DesignPatternChallenge_AbstractFactory.ConcreteProducts.PagSeguro;

namespace DesignPatternChallenge_AbstractFactory.ConcreteFactories
{
    internal class PagSeguroPaymentFactory : IPaymentProviderFactory
    {
        public IProcessor CreateProcessor()
        {
            return new PagSeguroProcessor();
        }

        public IValidator CreateValidator()
        {
            return new PagSeguroValidator();
        }

        public ILogger CreateLogger()
        {
            return new PagSeguroLogger();
        }
    }
}
